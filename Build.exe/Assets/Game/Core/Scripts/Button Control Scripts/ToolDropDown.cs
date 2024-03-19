using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolDropDown: MonoBehaviour
{
    public Dropdown toolDrop;
    public GameObject toolTextObject;

    void Start()
    {
        if(GameControl.control.Prace!="Dwarf")
        {
            toolDrop.gameObject.SetActive(false);
            toolTextObject.gameObject.SetActive(false); // text gameObject goes with it
        }
        
        if(GameControl.control.Pclass!="Bard")
        {
            toolDrop.gameObject.SetActive(false);
            toolTextObject.gameObject.SetActive(false);
        }
    }

    public void OnEdit()
    {
        string tool = toolDrop.options[toolDrop.value].text;
        GameControl.control.tProficiencies = tool;
    }
}