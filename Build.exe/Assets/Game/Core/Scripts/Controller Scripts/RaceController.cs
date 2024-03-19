using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RaceController : MonoBehaviour
{
    public static RaceController race;

    //Race variables
    public string Racename;
    public string RaceInfo;
    public GameObject model;
    public Texture2D newTexture;

    //Description variables
    public Text Description;
    public RawImage Race;
    public Texture2D raceText;


    /* This functions works whenever the mouse pointer hovers over the button and the following information is displayed
    The description is replaced with the Racename and RaceInfo
    */
    public void HoverOver()
    {
        Description.text=Racename+": "+RaceInfo;;
        Race.texture=newTexture;
        
    }

    
    /*
        When the button is no longer hovered over return to the default state 
        Race and image texture are set back to their default state
    */
    public void HoverExit()
    {
        Description.text= "The description of each race includes racial traits that are common to members of that race. The following entries appear among the traits of most races.";
        Race.texture=raceText;
    }

      /* 
        When the button is selected 
        the race variable is set to the race the button is assigend to
        The texture and description are updated to the corresponding button information passed 
        (This whole function is using UpdatedSelected)
    */
    public void OnSelectTile()
    {
        GameControl.control.playermodel=model;
        Race.texture=newTexture;
        Description.text=Racename+": "+RaceInfo;
        GameControl.control.Prace=Racename;
    }

    /* When the button is deselect everything is going back to default like hoverExit */
    public void onDeselect()
    {
        Description.text= "The description of each race includes racial traits that are common to members of that race. The following entries appear among the traits of most races.";
        Race.texture= raceText;
    }

    public void SceneLoader()
    {
        GameControl.control.playermodel = model;
        GameControl.control.Prace = Racename;
        SceneManager.LoadScene("RaceExtended");
    }
}
