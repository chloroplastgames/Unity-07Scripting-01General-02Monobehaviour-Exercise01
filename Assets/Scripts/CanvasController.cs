using UnityEngine;
using UnityEngine.UI;
using System;
using SimpleLibrary;

public class CanvasController : MonoBehaviour
{
    private const string UNKNOWN_OPERATION = "UNKNOWN OPERATION";
    private const string ERROR = "ERROR";

    private const int ADD = 0;
    private const int SUBSTRACT = 1;
    private const int MULTIPLY = 2;
    private const int DIVIDE = 3;
    
    // Inspector
    public InputField input1;
    public InputField input2;
    public Dropdown operation;
    public Text result;

    public void Compute()
    {
        try
        {
            float factor1 = float.Parse(input1.text);
            float factor2 = float.Parse(input2.text);
            switch (operation.value)
            {
                case ADD:
                    result.text = SimpleMath.Add(factor1, factor2).ToString();
                    break;
                case SUBSTRACT:
                    result.text = SimpleMath.Substract(factor1, factor2).ToString();
                    break;
                case MULTIPLY:
                    result.text = SimpleMath.Multiply(factor1, factor2).ToString();
                    break;
                case DIVIDE:
                    result.text = SimpleMath.Divide(factor1, factor2).ToString();
                    break;
                default:
                    result.text = UNKNOWN_OPERATION;
                    break;
            }
        } catch (FormatException)
        {
            result.text = ERROR;
        } 

    }

}
