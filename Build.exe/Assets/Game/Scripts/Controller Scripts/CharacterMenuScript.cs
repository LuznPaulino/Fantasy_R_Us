using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMenuScript : MonoBehaviour
{
    public Text strength;
    public Text dexterity;
    public Text constitution;
    public Text intelligence;
    public Text wisdom;
    public Text charisma;

    private GameObject CharModel;
    private GameObject hammer;
    private GameObject sword;
    private GameObject dagger;
    private GameObject bow;
    private GameObject spear;
    private GameObject staff;
    private GameObject spellBook;


    private GameObject shield;

    private GameObject lightArmor;
    private GameObject mediumArmor;
    private GameObject heavyArmor;
   

    public Text DropDownInfo;

    public Dropdown CharaterDropdown;

    void Start()
    {
        strength.text = GameControl.control.strength.ToString();
        dexterity.text = GameControl.control.dexterity.ToString();
        constitution.text = GameControl.control.constitution.ToString();
        intelligence.text = GameControl.control.intelligence.ToString();
        wisdom.text = GameControl.control.wisdom.ToString();
        charisma.text = GameControl.control.charisma.ToString();
        CharModel = GameControl.control.playermodel;
    }
    
    public void Age(string a)
    {
        GameControl.control.CharAge = a;
    }

    public void Name(string s)
    {
        GameControl.control.Charname = s;
    }

    public void DropdownEdit()
    {

        string change = CharaterDropdown.options[CharaterDropdown.value].text;
        switch (change)
        {
            case "Race":
                DropDownInfo.text = "Race: " + GameControl.control.Prace;
                break;
            case "Class":
                DropDownInfo.text = "Class: " + GameControl.control.Pclass;
                break;
            case "Skills":
                DropDownInfo.text = "Skills: " + GameControl.control.skill + "," + GameControl.control.skillClass + "," + GameControl.control.skillBckgrnd;
                break;
            case "Equipment":
                DropDownInfo.text = "Armor: " + GameControl.control.Parmor + " Equipment: " + GameControl.control.Pequip;
                break;
            case "Background":
                DropDownInfo.text = "Background: " + GameControl.control.Pbckgrnd;
                break;
            case "Spells":
                DropDownInfo.text = "Spells: \n" + GameControl.control.spells[0] + "\n" + GameControl.control.spells[1] + "\n" + GameControl.control.spells[2] + "\n" + GameControl.control.spells[3];
                break;
            case "Feats":
                DropDownInfo.text = "Feat: " + GameControl.control.Feats;
                break;
            case "Alignment":
                DropDownInfo.text = "Alignment: " + GameControl.control.alignment;
                break;
            case "Speed":
                DropDownInfo.text = "Speed: " + GameControl.control.speed;
                break;
            case "Size":
                DropDownInfo.text = "Size: " + GameControl.control.size;
                break;
            case "Language":
                DropDownInfo.text = "Language(s): " + GameControl.control.lang;
                break;
            case "Flaws":
                DropDownInfo.text = "Flaw(s): " + GameControl.control.flaws;
                break;
            case "Bonds":
                DropDownInfo.text = "Bond(s): " + GameControl.control.bonds;
                break;

            default:
                DropDownInfo.text = "Character Info";
                break;

        }
    }
}