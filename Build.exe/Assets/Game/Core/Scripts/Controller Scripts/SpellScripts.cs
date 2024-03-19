using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//Spell Script that is used and only avaliable for specific classes 
public class SpellScripts: MonoBehaviour
{
    public Dropdown[] spellsDrop;
    public Dropdown[] cantripDrop;

    private List<string> spells;
    private List<string> cantrips;
    public string C;
    public GameObject noSpells;
    public GameObject Spells;

    //Set spells according to the Class
    void Start()
    {
        C= GameControl.control.Pclass;
        noSpells.SetActive(false);
        Spells.SetActive(true);
        switch (C)
        {
            case "Bard":
            spells = new List<string>{"Sleep","Thunderwave","Healing Word","Bane","Disguise Self"};
            cantrips = new List<string>{"Blade Wand","Mage Hand","Mending","Light","True Strike"};
            ClearandFill();
            break;
            
            case "Cleric":
            spells = new List<string>{"Cure Wounds","Guiding Bolt","Inflict Wounds","Healing Word","Shield of Faith"};
            cantrips = new List<string>{"Light","Sacred Flame","Guidance","Resistance","Mending"};
            ClearandFill();
            break;
            
            case "Druid":
            spells = new List<string>{"Cure Wounds","Thunderwave","Healing Word","Detect Magic","Purify Food and Drink"};
            cantrips = new List<string>{"Frostbite","Poison Spray","Thorn Whip","Mending","Produce Flame"};
            ClearandFill();
            break;
            
            case "Paladin":
            spells = new List<string>{"Cure Wounds","Guiding Bolt","Inflict Wounds","Bless","Shield of Faith"};
            ClearandFill();
            //cantripDrop.ClearOptions();
            //cantripDrop.AddOptions(cantrips);
            break;
            
            case "Ranger":
            spells = new List<string>{"Cure Wounds","Goodberry","Jump","Alarm","Detect Magic"};
            ClearandFill();
            //cantripDrop.ClearOptions();
            //cantripDrop.AddOptions(cantrips);
            break;
            
            case "Sorcerer":
            spells = new List<string>{"Burning Hands","Magic Missile","Sleep","Thunderwave","Mage Armor"};
            cantrips = new List<string>{"Acid Spalsh","Blade Ward","Light","Fire Bolt","True Strike"};
            ClearandFill();
            break;
            
            case "Warlock":
            spells = new List<string>{"Hellish Rebuke","Protection from Evil", "Unseen Servant","Hex","Witch Bolt"};
            cantrips = new List<string>{"Blade Ward","Chill Touch","Poison Spray","True Strike","Minor Illusion"};
            ClearandFill();
            break;
            
            case "Wizard":
            spells = new List<string>{"Magic Missile","Sleep","Burning Hands","Mage Armor","Shield"};
            cantrips = new List<string>{"Acid Splash","Chill Touch","Mending","Fire Bolt","Poison Spray"};
            ClearandFill();
            break;
            
            default:
                noSpells.SetActive(true);
                Spells.SetActive(false);
            break;
        }
        for(int i=0;i <spellsDrop.Length;i++)
        {
            GameControl.control.spells[i]= spells[i];
            GameControl.control.cantrips[i]=cantrips[i];
        }
        spellsDrop[1].options.RemoveAt(0);
        spellsDrop[1].RefreshShownValue();
        //-----------------------------------
        spellsDrop[2].options.RemoveAt(0);
        spellsDrop[2].options.RemoveAt(0);
        spellsDrop[2].RefreshShownValue();
        //-------------------------------
        spellsDrop[3].options.RemoveAt(0);
        spellsDrop[3].options.RemoveAt(0);
        spellsDrop[3].options.RemoveAt(0);
        spellsDrop[3].RefreshShownValue();
        //-------------------------------
        cantripDrop[1].options.RemoveAt(0);
        cantripDrop[1].RefreshShownValue();
        //-----------------------------------
        cantripDrop[2].options.RemoveAt(0);
        cantripDrop[2].options.RemoveAt(0);
        cantripDrop[2].RefreshShownValue();
        //-------------------------------
        cantripDrop[3].options.RemoveAt(0);
        cantripDrop[3].options.RemoveAt(0);
        cantripDrop[3].options.RemoveAt(0);
        cantripDrop[3].RefreshShownValue();
    }

    void ClearandFill()
    {
        for(int i=0;i<4;i++)
        {
            spellsDrop[i].ClearOptions();
            cantripDrop[i].ClearOptions();
            if(C == "Ranger"|| C=="Paladin")
            {
                cantripDrop[i].gameObject.SetActive(false);
            }
            spellsDrop[i].AddOptions(spells);
            cantripDrop[i].AddOptions(cantrips);
        }
    }
    //Fill the Spell Text that correspond to the Class
    public void onEditSpells0()
    {
        string spell= spellsDrop[0].options[spellsDrop[0].value].text;
        GameControl.control.spells[0]=spell;
        for(int i =1; i< spellsDrop.Length;i++)
        {
            spellsDrop[i].ClearOptions();
            spellsDrop[i].AddOptions(spells);
            spellsDrop[i].options.RemoveAt(spellsDrop[0].value);
            spellsDrop[i].RefreshShownValue();
            
        }
        
    }
     public void onEditSpells1()
    {
        string spell= spellsDrop[1].options[spellsDrop[1].value].text;
        GameControl.control.spells[1]=spell;
        for(int i =2; i< spellsDrop.Length;i++)
        {
            spellsDrop[i].ClearOptions();
            spellsDrop[i].AddOptions(spells);
            spellsDrop[i].options.RemoveAt(spellsDrop[1].value);
            spellsDrop[i].options.RemoveAt(spellsDrop[0].value);
            spellsDrop[i].RefreshShownValue();
        }
        
        

    }
     public void onEditSpells2()
    {
        string spell= spellsDrop[2].options[spellsDrop[2].value].text;
        GameControl.control.spells[2]=spell;
        spellsDrop[3].ClearOptions();
        spellsDrop[3].AddOptions(spells);
        spellsDrop[3].options.RemoveAt(spellsDrop[0].value);
        spellsDrop[3].options.RemoveAt(spellsDrop[0].value);
        spellsDrop[3].options.RemoveAt(spellsDrop[0].value);
        spellsDrop[3].RefreshShownValue();
        
        

    }
     public void onEditSpells3()
    {
        string spell= spellsDrop[3].options[spellsDrop[3].value].text;
        GameControl.control.spells[3]=spell;
        

    }
//----------------------------------------------------------------------------

    public void onEditCantrips0()
    {
        string cantrip= cantripDrop[0].options[cantripDrop[0].value].text;
        GameControl.control.cantrips[0]=cantrip;
        for(int i =1; i< cantripDrop.Length;i++)
        {
            cantripDrop[i].ClearOptions();
            cantripDrop[i].AddOptions(cantrips);
            cantripDrop[i].options.RemoveAt(cantripDrop[0].value);
            cantripDrop[i].RefreshShownValue();
                
        }

    }
     public void onEditCantrips1()
    {
        string cantrip= cantripDrop[1].options[cantripDrop[1].value].text;
        GameControl.control.cantrips[1]=cantrip;
        for(int i =2; i< cantripDrop.Length;i++)
        {
            cantripDrop[i].ClearOptions();
            cantripDrop[i].AddOptions(cantrips);
            cantripDrop[i].options.RemoveAt(cantripDrop[1].value);
            cantripDrop[i].options.RemoveAt(cantripDrop[0].value);
            cantripDrop[i].RefreshShownValue();
            
        }
        
        

    }
     public void onEditCantrips2()
    {
        string cantrip= cantripDrop[2].options[cantripDrop[2].value].text;
        GameControl.control.cantrips[2]=cantrip;
        cantripDrop[3].ClearOptions();
        cantripDrop[3].AddOptions(cantrips);
        cantripDrop[3].options.RemoveAt(cantripDrop[2].value);
        cantripDrop[3].options.RemoveAt(cantripDrop[1].value);
        cantripDrop[3].options.RemoveAt(cantripDrop[0].value);
        cantripDrop[3].RefreshShownValue();
        
        

    }
     public void onEditCantrips3()
    {
        string cantrip= cantripDrop[3].options[cantripDrop[3].value].text;
        GameControl.control.cantrips[3]=cantrip;
        

    }



}