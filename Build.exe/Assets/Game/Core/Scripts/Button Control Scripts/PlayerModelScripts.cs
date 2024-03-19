using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/*
This Script is used to set and configure the model corresponding to the Class, Armor, and Equipment 
*/

public class PlayerModelScripts: MonoBehaviour

{
    //public GameObject[] races;
    //public GameObject[] raceSlots;
    public GameObject[] C;// GameModels for class
    public GameObject[] Armor_and_Equipment;//GameModels for equipment 
    
    public GameObject[] classSlots; // Class Slots

    string raceModel = GameControl.control.Prace; //Get race name
    string Armor= GameControl.control.Parmor; //Get armor name
    string Equipment = GameControl.control.Pequip; //Get equipment name 

    //Set Class Model
    void seClasstModel()
    {
        for(int i=0; i<=classSlots.Length;i++)
        {
            for(int j=0;j<=C.Length;j++)
            {
                if(C[j].tag==raceModel)
                {
                    ClassController.C.model=C[j];
                }
            }
        }
        
    }
    //Set Model according to Class, Armor and Equipment 
    void SetArmorModel()
    {
        for(int i=0;i<=Armor_and_Equipment.Length;i++)
        {
            if(C[i].tag==raceModel && Armor_and_Equipment[i].name == Armor+Equipment)
            {
                GameControl.control.playermodel=Armor_and_Equipment[i];
            }
        }
    }


}