using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*This Script will be used to hold and create Ability*/
public class AbilitySub: MonoBehaviour
{
    //Ability Info Buttons
    private string abilityInfo;

    //Ability Info Replacement Text
    public Text DescriptionText;

   //DropDown Information
    public Dropdown dropdown;
    public string Choice;
    List <string> dropDownChoices = new List<string>{"strength","dexterity","constitution","intelligence","wisdom","charisma"};

    private string abilitySub;
   
   void Start() 
   {
        if (GameControl.control.Psubrace != " " || GameControl.control.Psubrace != null) 
        {
            abilitySub = GameControl.control.Psubrace;
        }
      SwitchCases(0);
      dropdown.gameObject.SetActive(false);
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
      switch (abilitySub)
      {
         case "Black":
         abilityInfo="Acid Damage and Dexterity increased";
         if(Type == 1)
         {
            GameControl.control.dexterity+=1;
         }
         break;

         case "Blue":
         abilityInfo="Lightning Damage and Dexterity increased";
         if(Type == 1)
         {
            GameControl.control.dexterity+=1;
           
         }
         break;
         
         case "Brass":
         abilityInfo="Fire Damage and Dexterity increased";
         if(Type == 1)
         {
            GameControl.control.dexterity+=1;
           
         }
         break;

         case "Bronze":
         abilityInfo="Lightning Damage and Dexterity increased";
         if(Type == 1)
         {
            GameControl.control.dexterity+=1;
   
         }
         break;

         case "Copper":
         abilityInfo="Acid Damage and Dexterity increased";
         if(Type == 1)
         {
            GameControl.control.dexterity+=1;
         }
         break;

         case "Gold":
         abilityInfo="Fire Damage and Dexterity increased";
         if(Type == 1)
         {
            GameControl.control.dexterity+=1;
         }
         break;

         case "Green":
         abilityInfo="Poison Damage and Dexterity increased";
         if(Type == 1)
         {
            GameControl.control.dexterity+=1;
         }
         break;

         case "Red":
         abilityInfo="Red Damage and Dexterity increased";
         if(Type == 1)
         {
            GameControl.control.dexterity+=1;
         }
         break;

         case "Silver":
         abilityInfo="Cold Damage and Constitution increased";
         if(Type == 1)
         {
            GameControl.control.constitution+=1;
         }
         break;

         case "White":
         abilityInfo="Cold Damage and Constitution increased";
         if(Type == 1)
         {
            GameControl.control.constitution+=1;
         }
         break;

         case "Hill Dwarf":
         abilityInfo="Wisdom increased";
         if(Type == 1)
         {
            GameControl.control.wisdom+=1;
         }
         break;

         case "Mountain Dwarf":
         abilityInfo="Strength increased";
         if(Type == 1)
         {
            GameControl.control.strength+=1;
         }
         break;

         case "Eladrin":
         abilityInfo="Intelligence increased";
         if(Type == 1)
         {
            GameControl.control.intelligence+=1;
         }
         break;

         case "High Elf":
         abilityInfo="Intelligence increased";
         if(Type == 1)
         {
            GameControl.control.intelligence+=1;
         }
         break;

         case "Wood Elf":
         abilityInfo="Wisdom increased";
         if(Type == 1)
         {
            GameControl.control.wisdom+=1;
         }
         break;

         case "Deep Gnome":
         abilityInfo="Dexterity increased";
         if(Type == 1)
         {
            GameControl.control.dexterity+=1;
         }
         break;

         case "Rock Gnome":
         abilityInfo="Constitution increased";
         if(Type == 1)
         {
            GameControl.control.constitution+=1;
         }
         break;

         case "Lightfoot Halfling":
         abilityInfo="Charisma increased";
         if(Type == 1)
         {
            GameControl.control.charisma+=1;
         }
         break;

         case "Stout Halfling":
         abilityInfo="Constitution increased";
         if(Type == 1)
         {
            GameControl.control.constitution+=1;
         }
         break;

         case "Variant Human":
         abilityInfo="Any ability increased";
         if(Type == 1)
         {
            dropdown.gameObject.SetActive(true);
            DropDownSelection();
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