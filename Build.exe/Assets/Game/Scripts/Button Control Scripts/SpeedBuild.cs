using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedBuild: MonoBehaviour
{
    private string Info;
    private string race;

    public Text DescriptionText;

    //Testing
    void Start() 
    {
        if (GameControl.control.Prace != " " || GameControl.control.Prace != null) 
        {
            race= GameControl.control.Prace;
        }
    }
    
    public void Button(int Type)
    {
        switch (race)
        {
            case "Dragonborn":
            if(Type ==1)
            {
                GameControl.control.speed= 30;
            }
            Info="Your speed is 30 feet";
            break;

            case "Dwarf":
            if(Type==1)
            {
                GameControl.control.speed= 25;
            }
            Info="Your speed is 25 feet";
            break;

            case "Elf":
            if(Type==1)
            {
                GameControl.control.speed=30;
            }
            Info="Your speed is 30 feet";
            break;

            case "Half-Elf":
            if(Type == 1 )
            {
                GameControl.control.speed= 30;
            }
            Info="Your speed is 30 feet";
            break;
            case "Gnome":
            if(Type == 1)
            {
                GameControl.control.speed=25;
            }
            Info="Your speed is ";
            break;

            case "Halfling":
            if(Type ==1 )
            {
                GameControl.control.speed= 25;
            }
            Info="Your speed is 25 feet";
            break;

            case "Half-Orc":
            if(Type == 1)
            {
                GameControl.control.speed= 30;
            }
            Info="Your speed is 30 feet";
            break;

            case "Human":
            if(Type ==1)
            {
                GameControl.control.speed= 30;
            }
            Info="Your speed is 30 feet";
            break;

            case "Tiefling":
            if(Type == 1)
            {
                GameControl.control.speed= 30;
            }
            Info="Your speed is 30 feet";
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