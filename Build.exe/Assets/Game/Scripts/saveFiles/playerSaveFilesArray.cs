using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class playerSaveFilesArray : MonoBehaviour
{
    //Three different save spots
    public playerSave[] playerDataSave = new playerSave[3];

    //This function saves the data from the game controller
    public void saveTheFile(int place)
    {
        //The pathway of the save text file
        string savePathway = "Game Saves/save" + place + ".txt";
        if (!File.Exists(savePathway)){
            //GameObject.FindObjectOfType<GameControl>()
            //File.Create(savePathway)
        }
        else
        {

        }
    }

    public void replaceTheFile()
    {

    }

    public void deleteTheFile()
    {

    }
}
