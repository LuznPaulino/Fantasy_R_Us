using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class playerSaveFilesArray : MonoBehaviour
{
    //Three different save spots
    public playerSave[] playerDataSave = new playerSave[3];
    //The pathway of the save text file
    string savePathway = "Game Saves/saveFile.txt";

    public GameObject Slots; // enable UI
    public GameObject defaultUI; // disable UI

    //This function saves the data from the game controller
    public void saveTheFile(int place)
    {
        //checks to see if there is no file at this pathway
        if (!File.Exists(savePathway)) {
            //This saves the data from the output of the the function
            playerSave thePlayerToBeSaved = thePlayerCharacteristicsThatWillBeSaved();
            //Stores the data into a specific place on the playerDataSave array
            playerDataSave[place] = thePlayerToBeSaved;
            //Converts the array to json
            string playerData = JsonUtility.ToJson(playerDataSave);
            //Writes down the player data to a new file at the pathway
            File.WriteAllText(savePathway, playerData);
        }
        else
        {
            //Reads all the file data from the pathway
            string fileInfo = File.ReadAllText(savePathway);
            //Converts from json to the class array
            playerDataSave = JsonUtility.FromJson<playerSave[]>(savePathway);
            //This saves the data from the output of the the function
            playerSave thePlayerToBeSaved = thePlayerCharacteristicsThatWillBeSaved();
            //Stores the data into a specific place on the playerDataSave array
            playerDataSave[place] = thePlayerToBeSaved;
            //Converts the array back to json
            string playerData = JsonUtility.ToJson(playerDataSave);
            //Writes down the player data to file at the pathway
            File.WriteAllText(savePathway, playerData);
        }
    }

    // This function will delete the save file
    public void deleteTheFile()
    {
        //Deletes the file
        File.Delete(savePathway);
    }

    //This function deletes data from a specific data slot
    public void deleteTheData(int place)
    {
        //Reads all the file data from the pathway
        string fileInfo = File.ReadAllText(savePathway);
        //Converts from json to the class array
        playerDataSave = JsonUtility.FromJson<playerSave[]>(savePathway);
        //Stores deletes the data
        playerDataSave[place] = new playerSave();
        //Converts the array back to json
        string playerData = JsonUtility.ToJson(playerDataSave);
        //Writes down the player data to file at the pathway
        File.WriteAllText(savePathway, playerData);
    }

    //This function opens and retrieves the data from the file and apply it to the player
    public void openTheData(int place)
    {
        // enabling the Character archive UI
        defaultUI.SetActive(false);
        Slots.SetActive(true);

        //Reads all the file data from the pathway
        string fileInfo = File.ReadAllText(savePathway);
        //Converts from json to the class array
        playerDataSave = JsonUtility.FromJson<playerSave[]>(savePathway);
        //Uses this function to apply the data to the Game Controller
        thePlayerCharacteristicsThatWillBeApplied(playerDataSave,place);
    }

    //This function allows for conversion of GameControl data to the playerSave class
    public playerSave thePlayerCharacteristicsThatWillBeSaved()
    {
        playerSave playerReturnValue = new playerSave {
            playermodel = GameObject.FindObjectOfType<GameControl>().playermodel,
            Prace = GameObject.FindObjectOfType<GameControl>().Prace,
            Pclass = GameObject.FindObjectOfType<GameControl>().Pclass,
            Psubrace = GameObject.FindObjectOfType<GameControl>().Psubrace,
            Pbckgrnd = GameObject.FindObjectOfType<GameControl>().Pbckgrnd,
            Feats = GameObject.FindObjectOfType<GameControl>().Feats,
            Parmor = GameObject.FindObjectOfType<GameControl>().Parmor,
            Pequip = GameObject.FindObjectOfType<GameControl>().Pequip,
            flaws = GameObject.FindObjectOfType<GameControl>().flaws,
            bonds = GameObject.FindObjectOfType<GameControl>().bonds,
            Charname = GameObject.FindObjectOfType<GameControl>().Charname,
            CharAge = GameObject.FindObjectOfType<GameControl>().CharAge,
            alignment = GameObject.FindObjectOfType<GameControl>().alignment,
            tProficiencies = GameObject.FindObjectOfType<GameControl>().tProficiencies,
            ability = GameObject.FindObjectOfType<GameControl>().ability,
            size = GameObject.FindObjectOfType<GameControl>().size,
            lang = GameObject.FindObjectOfType<GameControl>().lang,
            skill = GameObject.FindObjectOfType<GameControl>().skill,
            skillClass = GameObject.FindObjectOfType<GameControl>().skillClass,
            skillBckgrnd = GameObject.FindObjectOfType<GameControl>().skillBckgrnd,
            speed = GameObject.FindObjectOfType<GameControl>().speed,
            spells = GameObject.FindObjectOfType<GameControl>().spells,
            cantrips = GameObject.FindObjectOfType<GameControl>().cantrips,
        };

        return playerReturnValue;
    }

    //This function allows for conversion of the playerSave class to GameControl data
    public void thePlayerCharacteristicsThatWillBeApplied(playerSave[] input,int place)
    {

        GameObject.FindObjectOfType<GameControl>().playermodel = input[place].playermodel;
        GameObject.FindObjectOfType<GameControl>().Prace = input[place].Prace;
        GameObject.FindObjectOfType<GameControl>().Pclass = input[place].Pclass;
        GameObject.FindObjectOfType<GameControl>().Psubrace = input[place].Psubrace;
        GameObject.FindObjectOfType<GameControl>().Pbckgrnd = input[place].Pbckgrnd;
        GameObject.FindObjectOfType<GameControl>().Feats = input[place].Feats; // no longer needed 
        GameObject.FindObjectOfType<GameControl>().Parmor = input[place].Parmor;
        GameObject.FindObjectOfType<GameControl>().Pequip = input[place].Pequip;
        GameObject.FindObjectOfType<GameControl>().flaws = input[place].flaws;
        GameObject.FindObjectOfType<GameControl>().bonds = input[place].bonds;
        GameObject.FindObjectOfType<GameControl>().Charname = input[place].Charname;
        GameObject.FindObjectOfType<GameControl>().CharAge = input[place].CharAge;
        GameObject.FindObjectOfType<GameControl>().alignment = input[place].alignment;
        GameObject.FindObjectOfType<GameControl>().tProficiencies = input[place].tProficiencies;
        GameObject.FindObjectOfType<GameControl>().ability = input[place].ability;
        GameObject.FindObjectOfType<GameControl>().size = input[place].size;
        GameObject.FindObjectOfType<GameControl>().lang = input[place].lang;
        GameObject.FindObjectOfType<GameControl>().skill = input[place].skill;
        GameObject.FindObjectOfType<GameControl>().skillClass = input[place].skillClass;
        GameObject.FindObjectOfType<GameControl>().skillBckgrnd = input[place].skillBckgrnd;
        GameObject.FindObjectOfType<GameControl>().speed = input[place].speed;
        GameObject.FindObjectOfType<GameControl>().spells = input[place].spells;
        GameObject.FindObjectOfType<GameControl>().cantrips = input[place].cantrips;
    }
}