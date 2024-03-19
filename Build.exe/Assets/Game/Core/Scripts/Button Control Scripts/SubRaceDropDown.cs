using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//SubRace Dropdown Script
public class SubRaceDropDown: MonoBehaviour
{
    public Dropdown dropdown;
    public Text DescriptionText;
    List<string> SubRace = new List<string>();
    private string Prace;
    // add stuff here
    public Material DwarfMat;
    public Material DragonMat;
    public Material ElfMat;
    public Material GnomeMat;
    public Material HalfMat;
    public Material TiefMat;


    //Colors
    Color32 gold = new Color32(255,223,0,255); 
    Color32 brass = new Color32(181,166,66,255);
    Color32 silver = new Color32(192,192,192,255);
    Color32 copper = new Color32(184,115,51,255);
    Color32 bronze = new Color32(255,87,51,255);

    Color32 lightG = new Color32(44,238,144,255);
    Color32 brown = new Color32(65,42,42,255);
    Color32 maroon = new Color32(128,0,0,255);
    Color32 navyB = new Color32(0,0,128,255);
    Color32 darkY = new Color32(255,87,51,255);
    Color32 darkGy = new Color32(99,102,106,255);

    // original colors
    Color32 dragon = new Color32(140,43,111,255);
    Color32 dwarf = new Color32(235,148,123,255);
    Color32 elf = new Color32(237,241,169,255);
    Color32 gnome = new Color32(214,138,255,255);
    Color32 half = new Color32(255,109,192,255);
    Color32 tief = new Color32(255,0,6,255);
    

    void Start()
    {
        if (GameControl.control.Prace != " "|| GameControl.control.Prace!=null) 
        {
            Prace = GameControl.control.Prace;
        }
        dropdown.gameObject.SetActive(true); 
        if(GameControl.control.Psubrace != " ")
        {   
            dropdown.options[1].text=GameControl.control.Psubrace;
        }
        switch (Prace)
        {
            case "Dragonborn":
            SubRace = new List <string>{"Black","Blue","Brass","Bronze","Copper","Gold","Green","Red","Silver","White"};
            dropdown.ClearOptions();
            dropdown.AddOptions(SubRace);
                DescriptionText.text = "Born from a dragon gives you special traits! Choose your favorite one";
                if (dropdown.options[0].text == SubRace[0])
                {
                    DescriptionText.text = "Black dragons are dangerous, filled with acid. Your parent gifted you will acid damage and resistence. You may not be a full black dragon, but you will definitely hit like one";
                }
                else if (dropdown.options[1].text == SubRace[1])
                {
                    DescriptionText.text = "Blue dragons are quick filled with electrical energy. Your parent gifted you will lightning damage and resistence. You may not be the size of a blue dragon, but you will definitely hit like one";
                }
                else if (dropdown.options[1].text == SubRace[2])
                {
                    DescriptionText.text = "Brass dragons are choatic and filled with firey rage. Your parent gifted you will fire damage and resistence. Ah, a true brass dragonborn";
                }
                else if (dropdown.options[1].text == SubRace[3])
                {
                    DescriptionText.text = "Ah, Bronze dragons are choatic in nature but fun with electricity! Your parent gifted you will lightning damage and resistence";
                }
                else if (dropdown.options[1].text == SubRace[4])
                {
                    DescriptionText.text = "Copper dragons are filled with acid and past regrets. Your parent gifted you will acid damage and resistence.";
                }
                else if (dropdown.options[1].text == SubRace[5])
                {
                    DescriptionText.text = "Gold Dragons! Beautiful but deadly. This shiny parent of your gifted you will the ability to deal fire damage and resist it too!";
                }
                else if (dropdown.options[1].text == SubRace[6])
                {
                    DescriptionText.text = "Green Dragons are rare and special in their own way! They are the only masters in poison breathes and swampy grounds. Congrats! You're able to deal posion damage and resist it!";
                }
                else if (dropdown.options[1].text == SubRace[6])
                {
                    DescriptionText.text = "Red Dragons...The standard dragons you always see being displayed in stories. You're in luck! If you want fire damage and resistence, then you got for your dragon parent";
                }
                else if (dropdown.options[1].text == SubRace[7])
                {
                    DescriptionText.text = "Silver Damages...They slap you with ice tubes....they are inaffective";
                }
                else if (dropdown.options[1].text == SubRace[8])
                {
                    DescriptionText.text = "Like Silver Damages, White dragons deal icy damage that you can resist!";
                }
                break;

            case "Dwarf":
            SubRace= new List<string>{"Hill Dwarf","Mountain Dwarf"};
            dropdown.ClearOptions();
                dropdown.AddOptions(SubRace);
                if(dropdown.options[0].text == SubRace[0])
                {
                    DescriptionText.text = "Hill Dwarfs are located in the high hills of the lands! They taught the value of strength and toughness through their surrounding";
                }
                else if (dropdown.options[1].text == SubRace[1])
                {
                    DescriptionText.text = "Mountains Dwarfs live deep into the mountains, forging and smelting the finest of ores to provide the greatest of weapons. Each young lad is taught how to create armor as a right of passage";
                }
                
            break;

            case "Elf":
            SubRace = new List<string>{"High Elf","Wood Elf"};
            dropdown.ClearOptions();
            dropdown.AddOptions(SubRace);
                if (dropdown.options[0].text == SubRace[0])
                {
                    DescriptionText.text = "High Elves are the highly intelligent elves that rule over most the lands. They are high in royalty and their ego...watch out";
                }
                else if (dropdown.options[1].text == SubRace[1])
                {
                    DescriptionText.text = "Wood Elves are elfs who seek and cherish the values of nature around them. They are know for their adaptiveness and stubborn hearts";
                }
            break;

            case "Gnome":
            SubRace= new List<string>{"Deep Gnome","Rock Gnome"};
            dropdown.ClearOptions();
            dropdown.AddOptions(SubRace);
                if (dropdown.options[0].text == SubRace[0])
                {
                    DescriptionText.text = "Deep Gnome are known to live deep undergrounds. They are well hated!";
                }
                else if (dropdown.options[1].text == SubRace[1])
                {
                    DescriptionText.text = "Rock Gnomes are gnomes.... that are made of rocks";
                }
            break;

            case "Halfling":
            SubRace = new List<string>{"Lightfoot Halfling","Stout Halfling"};
            dropdown.ClearOptions();
            dropdown.AddOptions(SubRace);
                if (dropdown.options[0].text == SubRace[0])
                {
                    DescriptionText.text = "Lightfoot Halflings are known to be very nice and charismatic!";
                }
                else if (dropdown.options[1].text == SubRace[1])
                {
                    DescriptionText.text = "Stout Halflings are the opposite of Lightfoot Halflings. They are known to be the cruelest and toughes Halflings.";
                }
                
            break;

            case "Tiefling":
            SubRace = new List<string>{"Red Tiefling","Blue Tiefling"};
            dropdown.ClearOptions();
            dropdown.AddOptions(SubRace);
            if (dropdown.options[0].text == SubRace[0])
                {
                    DescriptionText.text = "Red Tiefling are amongst the most common variants of the race. They are known to be fire resistent and charming!";
                }
            else if (dropdown.options[1].text == SubRace[1])
                {
                    DescriptionText.text = "Blue Tiefling variant are seen in the snowy mountains and highly cold areas. They are known to be cold resistent!";
                }
            break;

            default:
                dropdown.ClearOptions();
                break;
        }
        GameControl.control.Psubrace = dropdown.options[0].text.ToString();
        onEdit();
    }
        
    public void onEdit()
    {
        string Psubrace = dropdown.options[dropdown.value].text; 
        GameControl.control.Psubrace=Psubrace;
       
        if (Prace == "Dragonborn") // done
        {
            switch (Psubrace)
            {
                case "Black":
                    DragonMat.SetColor("_Color", Color.black);
                    DescriptionText.text = "Black dragons are dangerous, filled with acid. Your parent gifted you will acid damage and resistence. You may not be a full black dragon, but you will definitely hit like one";
                    break;
                case "Blue":
                    DragonMat.SetColor("_Color", Color.blue);
                    DescriptionText.text = "Blue dragons are quick filled with electrical energy. Your parent gifted you will lightning damage and resistence. You may not be the size of a blue dragon, but you will definitely hit like one";
                    break;
                case "Gold":
                    DragonMat.SetColor("_Color", gold);
                    DescriptionText.text = "Gold Dragons! Beautiful but deadly. This shiny parent of your gifted you will the ability to deal fire damage and resist it too!";
                    break;
                case "Red":
                    DragonMat.SetColor("_Color", Color.red);
                    DescriptionText.text = "Red Dragons...The standard dragons you always see being displayed in stories. You're in luck! If you want fire damage and resistence, then you got for your dragon parent";
                    break;
                case "Green":
                    DragonMat.SetColor("_Color", Color.green);
                    DescriptionText.text = "Green Dragons are rare and special in their own way! They are the only masters in poison breathes and swampy grounds. Congrats! You're able to deal posion damage and resist it!";
                    break;
                case "Brass":
                    DragonMat.SetColor("_Color", brass);
                    DescriptionText.text = "Brass dragons are choatic and filled with firey rage. Your parent gifted you will fire damage and resistence. Ah, a true brass dragonborn";
                    break;
                case "Copper":
                    DragonMat.SetColor("_Color", copper);
                    DescriptionText.text = "Copper dragons are filled with acid and past regrets. Your parent gifted you will acid damage and resistence.";
                    break;
                case "Silver":
                    DragonMat.SetColor("_Color", silver);
                    DescriptionText.text = "Silver Damages...They slap you with ice tubes....they are inaffective";
                    break;
                case "White":
                    DragonMat.SetColor("_Color", Color.white);
                    DescriptionText.text = "Like Silver Damages, White dragons deal icy damage that you can resist!";
                    break;
                case "Bronze":
                    DragonMat.SetColor("_Color", bronze);
                    DescriptionText.text = "Ah, Bronze dragons are choatic in nature but fun with electricity! Your parent gifted you will lightning damage and resistence";
                    break;

            }
        }

        if (Prace == "Dwarf")  // done
        {
            switch(Psubrace)
            {
                case "Hill Dwarf":
                    DwarfMat.SetColor("_Color", lightG);
                    DescriptionText.text = "Hill Dwarfs are located in the high hills of the lands! They taught the value of strength and toughness through their surrounding";
                    break;
                case "Mountain Dwarf":
                    DwarfMat.SetColor("_Color", Color.cyan);
                    DescriptionText.text = "Mountains Dwarfs live deep into the mountains, forging and smelting the finest of ores to provide the greatest of weapons. Each young lad is taught how to create armor as a right of passage";
                    break;
            }
            
            
        }

        if (Prace == "Elf") // done
        {
            switch(Psubrace)
            {
                case "High Elf":
                    ElfMat.SetColor("_Color", darkY);
                    DescriptionText.text = "High Elves are the highly intelligent elves that rule over most the lands. They are high in royalty and their ego...watch out";
                    break;
                case "Wood Elf":
                    ElfMat.SetColor("_Color", brown);
                    DescriptionText.text = "Wood Elves are elfs who seek and cherish the values of nature around them. They are know for their adaptiveness and stubborn hearts";
                    break;
            }
        }

        if(Prace == "Gnome") // done
        {
            switch(Psubrace)
            {
                case "Deep Gnome":
                    GnomeMat.SetColor("_Color", darkGy);
                    DescriptionText.text = "Deep Gnome are known to live deep undergrounds. They are well hated!";
                    break;
                case "Rock Gnome":
                    GnomeMat.SetColor("_Color", Color.grey);
                    DescriptionText.text = "Rock Gnomes are gnomes.... that are made of rocks";
                    break;
            }
        }

        if (Prace == "Halfling") // done
        {
            switch (Psubrace)
            {
                case "Lightfoot Halfling": 
                    GnomeMat.SetColor("_Color", Color.yellow);
                    DescriptionText.text = "Lightfoot Halflings are known to be very nice and charismatic!";
                    break;
                case "Stout Halfling":
                    GnomeMat.SetColor("_Color", Color.magenta);
                    DescriptionText.text = "Stout Halflings are the opposite of Lightfoot Halflings. They are known to be the cruelest and toughes Halflings.";
                    break;
            }
            
        }


        if (Prace == "Tiefling") // done
        {
            switch (Psubrace)
            {
                case "Red Tiefling":
                    TiefMat.SetColor("_Color", maroon);
                    DescriptionText.text = "Red Tiefling are amongst the most common variants of the race. They are known to be fire resistent and charming!";
                    break;
                case "Blue Tiefling":
                    TiefMat.SetColor("_Color", navyB);
                    DescriptionText.text = "Blue Tiefling variant are seen in the snowy mountains and highly cold areas. They are known to be cold resistent!";
                    break;
            }
           
        }
    }   
}