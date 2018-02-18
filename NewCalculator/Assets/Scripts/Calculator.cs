using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Calculator : MonoBehaviour {
    [SerializeField]
    Text inputField;
    string inputString;
    string gNumber = "";
    int[] number = new int[2];
    int i = 0;
    int result;
    
    string operatorSign;
    bool reset = false;
    public void buttonPressed()
    {
        if (reset == true)
        {
            inputString = "";
            inputField.text = "";
            i = 0;
            number = new int[2];
            reset = false;
        }
        inputField.text = "";
        string buttonValue;
        
            buttonValue = EventSystem.current.currentSelectedGameObject.name;
        if (buttonValue == "1" || buttonValue == "2" || buttonValue == "3" || buttonValue == "4" || buttonValue == "5" || buttonValue == "6" || buttonValue == "7" || buttonValue == "8" || buttonValue == "9" || buttonValue == "0" )
        {
            gNumber += buttonValue;
            Debug.Log("gNumber =" + gNumber);
        }
        else if (buttonValue == "-" || buttonValue == "=" || buttonValue == "+")
        {
            number[i] = int.Parse(gNumber);
            gNumber = "";
            Debug.Log(number[0] + " " + number[1]);
            i++;
            switch (buttonValue)
            {
                case "-":
                    operatorSign = buttonValue;
                    break;

                case "+":
                    operatorSign = buttonValue;
                    break;

                case "=":
                    switch (operatorSign)
                    {
                        case "-":
                          result=  number[0] - number[1];
                            Debug.Log("Result of - " + result);
                            break;
                        case "+":
                            result = number[0] + number[1];
                            Debug.Log("Result of + " + result);
                            break;
                    }
                    reset = true;
                    break;

            }
        }
        if (buttonValue != "=")
        {
            inputString += buttonValue;
        }
        else if (buttonValue == "=")
        {
            
            inputString = result.ToString();
        }
        inputField.text = inputString;

       
       // inputField.text = inputString;
    }
}
