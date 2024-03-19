using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* This Script is meant for the Buttons in the Equipment Section for equipment 
*/

public class EquipmentScriptBtns: MonoBehaviour
{

    public Text item;//Drag and Drop textfield here 


    //Set equip in Game Control 
    public void OnSelectTile()
    {
        GameControl.control.Pequip=item.text.ToString();
    }
}