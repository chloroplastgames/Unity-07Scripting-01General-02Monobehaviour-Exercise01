using UnityEngine;
using UnityEngine.UI;
using BasicOperationsLibrary;


public class Canvas : MonoBehaviour
{
    private float firstFactor;
    private float secondFactor;
    private Text resultText;

    private void Awake()
    {
        InputField firstFactorInputField = transform.Find("FirstFactor").Find("InputField").GetComponent<InputField>();
        InputField.SubmitEvent firstFactorInputFieldSubmitEvent = new InputField.SubmitEvent();
        firstFactorInputFieldSubmitEvent.AddListener(SetFirstFactor);
        firstFactorInputField.onEndEdit = firstFactorInputFieldSubmitEvent;

        InputField secondFactorInputField = transform.Find("SecondFactor").Find("InputField").GetComponent<InputField>();
        InputField.SubmitEvent secondFactorInputFieldSubmitEvent = new InputField.SubmitEvent();
        secondFactorInputFieldSubmitEvent.AddListener(SetSecondFactor);
        secondFactorInputField.onEndEdit = secondFactorInputFieldSubmitEvent;

        transform.Find("ComputeButton").GetComponent<Button>().onClick.AddListener(() =>
        {
            BasicOperations basicOperations = new BasicOperations();
            float result = basicOperations.Addition(firstFactor, secondFactor);
            ShowResult(result);
        });

        resultText = transform.Find("Result").Find("Value").GetComponent<Text>();
    }

    private void SetFirstFactor(string value)
    {
        firstFactor = float.Parse(value);
    }

    private void SetSecondFactor(string value)
    {
        secondFactor = float.Parse(value);
    }

    private void ShowResult(float result)
    {
        resultText.text = result.ToString();
    }
}