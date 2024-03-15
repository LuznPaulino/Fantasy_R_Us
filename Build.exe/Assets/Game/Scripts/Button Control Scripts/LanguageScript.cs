using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageScript: MonoBehaviour
{
    private string Info;
    public Text DescriptionText;
    public string race;

     void Start()
    {
        race = GameControl.control.Prace;
        Race(0);
    }
   
    private void Race(int Type)
    {
        switch (race)
        {
            case "Dragonborn":
            if(Type ==1)
            {
                GameControl.control.lang= "Common/Draconic";
            }
            Info="Your main language is Draconic and Common";
            break;

            case "Dwarf":
            if(Type==1)
            {
                GameControl.control.lang= "Common/Dwarvish";
            }
            Info="Your main language is Dwarvish and Common";
            break;

            case "Elf":
            if(Type==1)
            {
                GameControl.control.lang= "Common/Elvish/Infernal";
            }
            Info="Your main language is Elvish, Common, and Infernal";
            break;

            case "Half-Elf":
            if(Type == 1 )
            {
                GameControl.control.lang= "Common/Elvish";
            }
            Info="Your languages are Common and Elvish";
            break;

            case "Gnome":
            if(Type == 1)
            {
                GameControl.control.lang= "Common/Gnomish";
            }
            Info="Your main language is Gnomish and Common";
            break;

            case "Halfling":
            if(Type ==1 )
            {
                GameControl.control.lang= "Common/Halfling";
            }
            Info="Your main language is Halfling and Common";
            break;

            case "Half-Orc":
            if(Type == 1)
            {
                GameControl.control.lang= "Common/Orc";
            }
            Info="Your languages are Common and Orc";
            break;

            case "Human":
            if(Type ==1)
            {
                GameControl.control.lang= "Common";
            }
            Info="Your main language is Common";
            break;

            case "Tiefling":
            if(Type == 1)
            {
                GameControl.control.lang= "Common/Infernal";
            }
            Info="Your languages are Common and Infernal";
            break;
        }
    }
     public void HoverOver()
    {
        Race(0);
        DescriptionText.text=Info;
    }

    public void HoverExit()
    {
        DescriptionText.text= " ";
    }

    public void OnSelectTile()
    {
        Race(1);
    }
}