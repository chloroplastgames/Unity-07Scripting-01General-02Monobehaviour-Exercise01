using UnityEngine;
using UnityEngine.UI;
using BasicOperationsLibrary;

public class Canvas : MonoBehaviour
{
    private enum Operations
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    }
    private Operations operation;

    private BasicOperations basicOperations;
    private float firstFactor;
    private float secondFactor;
    private Text resultText;

    private void Awake()
    {
        basicOperations = new BasicOperations();

        operation = Operations.Addition;

        transform.Find("FirstFactor").Find("InputField").GetComponent<InputField>().onEndEdit.AddListener(SetFirstFactor);

        transform.Find("SecondFactor").Find("InputField").GetComponent<InputField>().onEndEdit.AddListener(SetSecondFactor);

        transform.Find("OperationDropdown").GetComponent<Dropdown>().onValueChanged.AddListener(SetOperation);

        transform.Find("ComputeButton").GetComponent<Button>().onClick.AddListener(() =>
        {
            float result = 0;

            switch (operation)
            {
                case Operations.Addition:
                    result = basicOperations.Addition(firstFactor, secondFactor);
                    break;

                case Operations.Subtraction:
                    result = basicOperations.Subtraction(firstFactor, secondFactor);
                    break;

                case Operations.Multiplication:
                    result = basicOperations.Multiplication(firstFactor, secondFactor);
                    break;

                case Operations.Division:
                    if (secondFactor == 0)
                    {
                        ShowResultMessage("You can't divide by 0!");
                        return;
                    }

                    result = basicOperations.Division(firstFactor, secondFactor);
                    break;
            }

            ShowResult(result);
        });

        resultText = transform.Find("Result").Find("Value").GetComponent<Text>();
    }

    private void SetFirstFactor(string valueString)
    {
        if (valueString.Contains(","))
        {
            valueString = valueString.Replace(',', '.');
        }

        if (float.TryParse(valueString, out float value))
        {
            firstFactor = value;
            ShowResultMessage("First factor set!");
        }
        else
        {
            firstFactor = 0;
            ShowResultMessage("Invalid first factor, set to 0.");
        }
    }

    private void SetSecondFactor(string valueString)
    {
        if (valueString.Contains(","))
        {
            valueString = valueString.Replace(',', '.');
        }

        if (float.TryParse(valueString, out float value))
        {
            secondFactor = value;
            ShowResultMessage("Second factor set!");
        }
        else
        {
            secondFactor = 0;
            ShowResultMessage("Invalid second factor, set to 0.");
        }
    }

    private void SetOperation(int index)
    {
        switch (index)
        {
            case 0:
                operation = Operations.Addition;
                break;

            case 1:
                operation = Operations.Subtraction;
                break;

            case 2:
                operation = Operations.Multiplication;
                break;

            case 3:
                operation = Operations.Division;
                break;
        }
    }

    private void ShowResult(float result)
    {
        resultText.text = result.ToString("F2");
    }

    private void ShowResultMessage(string message)
    {
        resultText.text = message;
    }
}