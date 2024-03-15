using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*This Script will be used to hold and create Ability*/
public class Ability: MonoBehaviour
{
    //Ability Info Buttons
    private string abilityInfo;

    //Ability Info Replacement Text
    public Text DescriptionText;

   //DropDown Information
    public Dropdown dropdown;
    public GameObject dropDownText;
    public string Choice;
    List <string> dropDownChoices = new List<string>{"strength","dexterity","constitution","intelligence","wisdom","charisma"};

    private string abilityRace;
   
   void Start() 
   {
        if (GameControl.control.Prace != " "|| GameControl.control.Prace != null) 
        {
            abilityRace = GameControl.control.Prace;
        }
      SwitchCases(0);
      dropdown.gameObject.SetActive(false);
        dropDownText.gameObject.SetActive(false);
   }

   public void HoverOver()
   {
      DescriptionText.text=abilityInfo;
   }

   public void HoverExit()
   {
      DescriptionText.text=" ";
   }
   public void OnSelectTile()
   {
      SwitchCases(1);
   }

   private void SwitchCases(int Type)
   {
      switch (abilityRace)
      {
         case "Dragonborn":
         abilityInfo="Strength increase by 2 and Charisma by 1";
         if(Type == 1)
         {
            GameControl.control.strength+=2;
            GameControl.control.charisma+=1;
         }
         break;

         case "Dwarf":
         abilityInfo="Constitution increase by 2";
         if(Type == 1)
         {
            GameControl.control.constitution+=2;
           
         }
         break;
         
         case "Elf":
         abilityInfo="Dexterity increase by 2";
         if(Type == 1)
         {
            GameControl.control.dexterity+=2;
           
         }
         break;

         case "Gnome":
         abilityInfo="Intelligence increase by 2";
         if(Type == 1)
         {
            GameControl.control.intelligence+=2;
            dropdown.gameObject.SetActive(true);
            DropDownSelection();
         }
         break;

         case "Half-Elf":
         abilityInfo="Charisma increase by 2";
         if(Type == 1)
         {
            GameControl.control.charisma+=2;
            dropdown.gameObject.SetActive(true);
            DropDownSelection();
         }
         break;

         case "Halfling":
         abilityInfo="Dexterity increase by 2";
         if(Type == 1)
         {
            GameControl.control.dexterity+=2;
         }
         break;

         case "Half-Orc":
         abilityInfo="Strength increase by 2 and Constitution increase by 1";
         if(Type == 1)
         {
            GameControl.control.strength+=2;
            GameControl.control.constitution+=1;
         }
         break;

         case "Human":
         abilityInfo="All abilities increases by 1";
         if(Type == 1)
         {
            GameControl.control.strength+=1;
            GameControl.control.constitution+=1;
            GameControl.control.charisma+=1;
            GameControl.control.dexterity+=1;
            GameControl.control.wisdom+=1;
            GameControl.control.intelligence+=1;
         }
         break;

         case "Tiefling":
         abilityInfo="Charisma increase by 2 and Intelligence increase by 1";
         if(Type == 1)
         {
            GameControl.control.charisma+=2;
            GameControl.control.intelligence+=1;
         }
         break;
         
      }
   }

   public void DropDownSelection()
   {
      dropdown.AddOptions(dropDownChoices);

      Choice = dropdown.options[dropdown.value].text;

      switch (Choice)
      {
         case "strength":
         GameControl.control.strength+=1;
         break;
         case "dexterity":
         GameControl.control.dexterity+=1;
         break;
         case "constitution":
         GameControl.control.constitution+=1;
         break;
         case "intelligence":
         GameControl.control.intelligence+=1;
         break;
         case "wisom":
         GameControl.control.wisdom+=1;
         break;
         case "charisma":
         GameControl.control.charisma+=1;
         break;
      }
   }

}