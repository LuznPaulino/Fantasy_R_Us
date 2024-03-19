using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentScript : MonoBehaviour
{
    public Text [] armorText; //Gets text from UI
    public Text [] equipText; //Gets text from UI
    private string [] armor;
    private string [] equip;
    public string C;//Calls Pclass name from GameControl

   void Start()
   {
    C=GameControl.control.Pclass;
    //Switch cases for each class in the application 
        switch(C)
        {
            case "Barbarian": 
            armor = new string[3]{"Light armor","Medium armor","Shields"};
            equip = new string[2]{"Simple weapon","Martial weapon"};
            FillSlots();
            break;
            case "Bard":
            armor = new string[1]{"Light armor"};
            equip = new string[5]{"Simple weapon","Hand crossbows","Longsword","Rapiers","Shortsword"};
            FillSlots();
            break;
            case "Cleric":
            armor = new string[3]{"Light armor","Medium armor","Shields"};
            equip = new string[1]{"Simple weapon"};
            FillSlots();
            break;
            case "Druid":
            armor = new string[3]{"Light armor","Medium armor","Shields"};
            string[] eqip = new string[5]{"Club","Dagger","Dart","Javelin","Mace"};
            FillSlots();
            break;
            case "Fighter":
            armor = new string[4]{"Heavy armor","Medium armor","Light armor","Shields"};
            equip = new string[2]{"Simple weapon","Martial weapon"};
            FillSlots();
            break;
            case "Monk":
            armor = new string[1]{"No armor"};
            equip = new string[2]{"Simple weapon","Shortsword"};
            FillSlots();
            break;
            case "Paladin":
            armor = new string[4]{"Heavy armor","Medium armor","Light armor","Shields"};
            equip = new string[2]{"Simple weapon","Martial weapon"};
            FillSlots();
            break;
            case "Ranger":
            armor = new string[3]{"Light armor","medium armor","shields"};
            equip = new string[2]{"Simple weapon","Martial weapon"};
            FillSlots();
            break;
            case "Rogue":
            armor = new string[1]{"Light armor"};
            equip = new string[5]{"Simpl weapon","Hand crossbow","Longsword","Rapiers","Shortsword"};
            FillSlots();
            break;
            case "Sorcerer":
            armor = new string[1]{"No armor"};
            equip = new string[5]{"Dagger","Darts","Slings","Quarterstaffs","Light crossbows"};
            FillSlots();
            break;
            case "Warlock":
            armor = new string[1]{"Light armor"};
            equip = new string[1]{"Simple weapon"};
            FillSlots();
            break;
            case "Wizard":
            armor = new string[1]{"No armor"};
            equip = new string[5]{"Daggers","Darts","Slings","Quarterstaffs","Light crossbows"};
            FillSlots();
            break;

        }
   }

    //Fills each slot with the text and appropriate name 
   void FillSlots()
   {
        for(int i=0; i<armor.Length;i++)
        {
            armorText[i].text=armor[i];
        }
        for(int j=0; j < equip.Length;j++)
        {
            equipText[j].text=equip[j];
        }
   }
}
