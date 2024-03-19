using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
    This Script is used for the Class Scene, this script is meant for each individual button in the Scene 
*/

public class ClassController : MonoBehaviour
{
    //Static variable
    public static ClassController C;

    //Class variables
    public string className;
    public string classInfo;
    public GameObject model;
    public Texture2D newTexture;

    //Description variables 
    public Text Description;
    public RawImage Class;
    public Texture2D classText;



    /* This functions works whenever the mouse pointer hovers over the button and the following information is displayed
    The description is replaced with the ClassName and classInfo
    */
    public void HoverOver()
    {
        Description.text=className+": "+classInfo;;
        Class.texture=newTexture;
        
    }

    /*
        When the button is no longer hovered over return to the default state 
        Class and image texture are set back to their default state
    */
    public void HoverExit()
    {
        Description.text=" ";
        Class.texture=classText;
    }

    /* 
        When the button is selected 
        the class variable is set to the class the button is assigend to
        The texture and description are updated to the corresponding button information passed 
        (This whole function is using UpdatedSelected)
    */
    public void OnSelectTile()
    {
        GameControl.control.playermodel=model;
        Class.texture=newTexture;
        Description.text=className+": "+classInfo;
        GameControl.control.Pclass=className;
    }

    /* When the button is deselect everything is going back to default like hoverExit */
    public void onDeselect()
    {
        Description.text=" ";
        Class.texture= classText;
    }

    public void SceneLoader()
    {
        GameControl.control.Pclass = className;
        SceneManager.LoadScene("ClassExtended");
    }
}
