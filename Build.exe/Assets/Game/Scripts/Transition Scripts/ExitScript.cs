using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script used for Exiting the application during runtime

public class ExitScript : MonoBehaviour
{
    //Function for Exiting the game
    public void Exit()
    {
        Debug.Log("exitgame");
        Application.Quit();
    }
}
