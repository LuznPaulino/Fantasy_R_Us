using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
    This Script is used for the buttons in the Background scene
    This script is made for each individual button
*/

public class BackgroundControl : MonoBehaviour
{
    //Background variables 
    public string BckName;//Background name 
    public string BckInfo; //From DND website
    public Texture2D texture; // The sprite for the background

    //Description variables
    public Text Description; //The Text field BckInfo is replacing 
    public RawImage Bck; //Image where the sprite is replacing when performing one of the 4 functions below
    public Texture2D bckText; //Texture for set Background Image on Deselect


    /* This functions works whenever the mouse pointer hovers over the button and the following information is displayed
    The description is replaced with the BckName and BckInfo
    */
    public void HoverOver()
    {
        Description.text=BckName+": "+BckInfo;
        Bck.texture=texture;
  
    }

    /*
        When the button is no longer hovered over return to the default state 
        Background and image texture are set back to their default state
    */
    public void HoverExit()
    {
        Description.text= "Every story has a beginning. Your character’s background reveals where you came from, how you became an adventurer, and your place in the world. Your fighter might have been a courageous knig⁠ht or a grizzled so⁠ldier. Your wizard could have been a sage or an artisan. Your rogue might have gotten by as a guild thief or commanded audiences as a jester." + "Choosing a background provides you with important story cues about your character’s identity.";
        Bck.texture=bckText;
    }

    /* 
        When the button is selected 
        the background variable is set to the Background the button is assigend to
        The texture and description are updated to the corresponding button information passed 
        (This whole function is using UpdatedSelected)
    */
    public void OnSelectTile()
    {
        
        Bck.texture=texture;
        Description.text=BckName+": "+BckInfo; 
        GameControl.control.Pbckgrnd=BckName;
    }

    /* When the button is deselect everything is going back to default like hoverExit
    
    */
    public void onDeselect()
    {
        Description.text= "Every story has a beginning. Your character’s background reveals where you came from, how you became an adventurer, and your place in the world. Your fighter might have been a courageous knig⁠ht or a grizzled so⁠ldier. Your wizard could have been a sage or an artisan. Your rogue might have gotten by as a guild thief or commanded audiences as a jester." + "Choosing a background provides you with important story cues about your character’s identity.";
        Bck.texture= bckText;
    }

    public void SceneLoader()
    {
        GameControl.control.Pbckgrnd = BckName;
        SceneManager.LoadScene("BackgroundExtended");
    }
}
