using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


/*Feat Script at the moment according to the basic rules humans have the only feature*/
public class FeatScript: MonoBehaviour
{
    private string Choice;
    public Dropdown featDropDown;
    //Race variables
    public string Feat;
    public string FeatInfo;
    public GameObject NoFeats;
    public GameObject FeatDisplay;

    //Description variables
    public Text Description;
    
    void Start()
    {
        if(GameControl.control.Prace != "Human")
        {
            NoFeats.gameObject.SetActive(true);
            FeatDisplay.gameObject.SetActive(false);
        }
        else if(GameControl.control.Prace=="Human")
        {
            NoFeats.gameObject.SetActive(false);
            FeatDisplay.gameObject.SetActive(true);
            //featDropDown.gameObject.SetActive(false);
        }
    }

    /* This functions works whenever the mouse pointer hovers over the button and the following information is displayed
    The description is replaced with the Feat and Feat Info
    */
    public void HoverOver()
    {
        Description.text=Feat+": "+FeatInfo;
        
        
    }

    
    /*
        When the button is no longer hovered over return to the default state 
        Race andmare set back to their default state
    */
    public void HoverExit()
    {
        Description.text=" ";
    }

      /* 
        When the button is selected 
        the race variable is set to the race the button is assigend to
        The texture and description are updated to the corresponding button information passed 
        (This whole function is using UpdatedSelected)
    */
    public void OnSelectTile()
    {
        Description.text=Feat+": "+FeatInfo; 
        GameControl.control.Feats=Feat;
        if(Feat == "Athlete")
        {
            featDropDown.gameObject.SetActive(true);
            //Choices are Strength or Dexterity
        }
    }

    public void OnChange()
    {
        Choice = featDropDown.options[featDropDown.value].text;
    }

    /* When the button is deselect everything is going back to default like hoverExit */
    public void onDeselect()
    {
        Description.text=" ";
        
    }

    public void OnEdit()
    {
       
        switch (Feat)
        {
            case "Actor":
            GameControl.control.charisma+=1;
            break;
            case "Athlete":
            if(Choice=="Strength"){GameControl.control.strength+=1;}
            else{GameControl.control.dexterity+=1;}
            break;
        }
    }

    public void SceneLoader()
    {
        GameControl.control.Feats = Feat; //Update the name on the gamecontrol 
        SceneManager.LoadScene("Character Menu");
    }
    
}