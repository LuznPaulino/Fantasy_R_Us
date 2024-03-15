using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* This Script is meant for the Buttons in the Equipment Section for armor 
*/

public class ArmorScriptBtns: MonoBehaviour
{
    public Text armorplate;//Drag and Drop textfield here 
    //Set armor in Game Control 
    public void OnSelectTile()
    {
        GameControl.control.Parmor=armorplate.text.ToString();
    }
}