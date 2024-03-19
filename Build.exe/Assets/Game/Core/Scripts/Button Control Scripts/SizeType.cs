using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SizeType: MonoBehaviour
{
    private string Info;
    private string race;
    public Text DescriptionText;

    void Start() 
    {
        if (GameControl.control.Prace != " " || GameControl.control.Prace != null) 
        {
            race= GameControl.control.Prace;
        }
    }
    
    private void Button(int Type)
    {
        switch (race)
        {
            case "Dragonborn":
            if(Type ==1)
            {
                GameControl.control.size= "Medium";
            }
            Info="Your size is Medium";
            break;
            case "Dwarf":
            if(Type==1)
            {
                GameControl.control.size= "Medium";
            }
            Info="Your size is Medium";
            break;
            case "Elf":
            if(Type==1)
            {
                GameControl.control.size= "Medium";
            }
            Info="Your size is Medium";
            break;
            case "Half-Elf":
            if(Type == 1 )
            {
                GameControl.control.size= "Medium";
            }
            Info="Your size is Medium";
            break;
            case "Gnome":
            if(Type == 1)
            {
                GameControl.control.size= "Small";
            }
            Info="Your size is Small";
            break;
            case "Halfling":
            if(Type ==1 )
            {
                GameControl.control.size= "Small";
            }
            Info="Your size is Small";
            break;
            case "Half-Orc":
            if(Type == 1)
            {
                GameControl.control.size= "Medium";
            }
            Info="Your size is Medium";
            break;
            case "Human":
            if(Type ==1)
            {
                GameControl.control.size= "Medium";
            }
            Info="Your size is Medium";
            break;
            case "Tiefling":
            if(Type == 1)
            {
                GameControl.control.size= "Medium";
            }
            Info="Your size is Medium";
            break;
        }
    }

    public void HoverOver()
    {
        Button(0);
        DescriptionText.text=Info;
    }

    public void HoverExit()
    {
        DescriptionText.text= " ";
    }

    public void OnSelectTile()
    {
        Button(1);
    }

}