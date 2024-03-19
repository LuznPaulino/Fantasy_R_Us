using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rolls: MonoBehaviour
{   
    //Enter Stats Name here
    public string StatsName;
    public Text statsText;
    private int StatsMod;
    public Text modText;

    public void Roll()
    {
        int rand = Random.Range(3,19);
        switch (StatsName)
        {
            case "Strength":
            GameControl.control.strength=rand;
            statsText.text=rand.ToString();
            break;
            case "Dexterity":
            GameControl.control.dexterity=rand;
            statsText.text=rand.ToString();
            break;
            case "Constitution":
            GameControl.control.constitution=rand;
            statsText.text=rand.ToString();
            break;
            case "Intelligence":
            GameControl.control.intelligence=rand;
            statsText.text=rand.ToString();
            break;
            case "Wisdom":
            GameControl.control.wisdom=rand;
            statsText.text=rand.ToString();
            break;
            case "Charisma":
            GameControl.control.charisma=rand;
            statsText.text=rand.ToString();
            break;
            
        }
        StatsMod=rand;
        Mods();
    }

    public void Mods()
    {
        if(StatsMod == 3)
        {
            modText.text="-4";
        }
        if(StatsMod == 4 || StatsMod ==5)
        {
            modText.text="-3";
        }
        if(StatsMod == 6 || StatsMod == 7)
        {
            modText.text="-2";
        }
        if(StatsMod == 8 || StatsMod == 9)
        {
            modText.text="-1";
        }
        if(StatsMod == 10 || StatsMod == 11)
        {
            modText.text="0";
        }
        if(StatsMod == 12 || StatsMod == 13)
        {
            modText.text="1";
        }
        if(StatsMod == 14 || StatsMod == 15)
        {
            modText.text="2";
        }
        if(StatsMod == 16 || StatsMod == 17)
        {
            modText.text="3";
        }
        if(StatsMod ==18)
        {
            modText.text="4";
        }
    }

}