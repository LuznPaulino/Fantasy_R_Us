using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AlignmentDropDown: MonoBehaviour
{
    public Dropdown dropdown;

    public void OnEdit()
    {
        string align = dropdown.options[dropdown.value].text;
        GameControl.control.alignment = align;
    
    }
}