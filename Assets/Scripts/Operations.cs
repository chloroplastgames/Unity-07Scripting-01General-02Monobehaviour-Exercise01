using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using OperacionesBasicasLibrary;
using System;

public class Operations : MonoBehaviour
{
    #region Private Variables

    private Button _btnCompute;

    private InputField _firstFactorInput;

    private InputField _secondFactorInput; 

    private Text _resultText;

    private Dropdown _dropdownOperation; // 0 - add 1 - subtract 2 - mul 3 - divive

    #endregion 

    private void Awake()
    {
        _btnCompute = DataFactory.GetButtonCompute();

        _firstFactorInput = DataFactory.GetFirstFactorInput();

        _secondFactorInput = DataFactory.GetSecondFactorInput();

        _resultText = DataFactory.GetUIResult();

        _dropdownOperation = DataFactory.GetDropDown();
    }

    // Start is called before the first frame update
    void Start()
    {
        
        _btnCompute.onClick.AddListener(Execute);
    }

    private void Execute()
    {
        switch (_dropdownOperation.value)
        {
            case 0:
                ValidarOperacion(Operaciones.Sumar);
                return;
            case 1:
                ValidarOperacion(Operaciones.Restar);
                return;
            case 2:
                ValidarOperacion(Operaciones.Multiplicar);
                return;
            case 3:
                ValidarOperacion(Operaciones.Dividir);
                return;
        }
    }

    private void ValidarOperacion(Func<float,float,float> Execute )
    {
        float A, B;

        if(float.TryParse(_firstFactorInput.text,out A))
        {
            if(float.TryParse(_secondFactorInput.text, out B))
            { 
                _resultText.text = Execute(A, B).ToString(); // b = 0 es infinito para divisiones
                _resultText.color = Color.green;
            }
            else
            {
                ResultadoInvalido("Invalid SecondFactor");
            }
        }
        else
        {
            ResultadoInvalido("Invalid FirstFactor");
        }
    }

    private void ResultadoInvalido(string msg)
    {
        _resultText.text = msg;
        _resultText.color = Color.red;
    }
}
