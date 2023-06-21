using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class ControlsBase : MonoBehaviour
{
    public int axisX;
    public int axisY;
    public int axisXLast;
    public int axisYLast;
    public string buttonValue;

    public void Axis(InputAction.CallbackContext value){
        axisX = (int)Math.Round(value.ReadValue<Vector2>().x);
        axisY = (int)Math.Round(value.ReadValue<Vector2>().y);

        //Last direction
        if((int)Math.Round(value.ReadValue<Vector2>().x) != 0) axisXLast = (int)Math.Round(value.ReadValue<Vector2>().x);
        if((int)Math.Round(value.ReadValue<Vector2>().y) != -1) axisYLast = (int)Math.Round(value.ReadValue<Vector2>().y);
    }

    public void Button(InputAction.CallbackContext value){
        buttonValue = value.phase.ToString();
        print(value.phase.ToString());
        // if(value.phase.ToString() == "Started") // When start hold the button
        // if(value.phase.ToString() == "Performanced") // When button is hold
        // if(value.phase.ToString() == "Canceled") // When drop the button
    }
}
