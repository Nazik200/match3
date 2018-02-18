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
    int[] number = new int [];
    int i = 0;
    public void buttonPressed()
    {
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
            Debug.Log(number[i]);
            i++;  
        }

            inputString += buttonValue;
            inputField.text = inputString;

       
       // inputField.text = inputString;
    }
}
