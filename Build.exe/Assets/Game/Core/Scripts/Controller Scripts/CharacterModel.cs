using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterModel : MonoBehaviour
{
    private string armor;
    private string weapon;
    public GameObject Player;

    // Start is called before the first frame update

    void Start()
    {
        Player = GameControl.control.playermodel;
        armor= GameControl.control.Parmor;
        weapon = GameControl.control.Pequip;
        
        ResetModel();
        if(armor != "No armor" || armor != " ")
        {
            Player.transform.Find(armor).gameObject.SetActive(true);
        }
        if(weapon != " ")
        {
            Player.transform.Find(weapon).gameObject.SetActive(true);
        }
        else
        {
            Player.transform.Find("Simple weapon").gameObject.SetActive(true);
        }


    }

    void ResetModel()
    {
        switch (armor)
        {
            case "Heavy armor":
            Player.transform.Find(armor).gameObject.SetActive(true);
            break;
            case "Medium armor":
            Player.transform.Find(armor).gameObject.SetActive(true);
            break;
            case "Light armor":
            Player.transform.Find(armor).gameObject.SetActive(true);
            break;
            case "Shields":
            Player.transform.Find(armor).gameObject.SetActive(true);
            break;
            default:
            break;
            
        }
        switch (weapon)
        {
            
            case "Simple weapon":
           Player.transform.Find(weapon).gameObject.SetActive(true);
            break;
            case "Dagger":
           Player.transform.Find(weapon).gameObject.SetActive(true);
            break;
            case "Martial weapon":
           Player.transform.Find(weapon).gameObject.SetActive(true);
            break;
            case "Shortsword":
           Player.transform.Find(weapon).gameObject.SetActive(true);
            break;
            case "Rapiers":
           Player.transform.Find(weapon).gameObject.SetActive(true);
            break;
            case "Hand crossbows":
           Player.transform.Find(weapon).gameObject.SetActive(true);
            break;
            case "Darts":
           Player.transform.Find(weapon).gameObject.SetActive(true);
            break;
            case "Slings":
           Player.transform.Find(weapon).gameObject.SetActive(true);
            break;
            case "Quarterstaffs":
           Player.transform.Find(weapon).gameObject.SetActive(true);
            break;
            case "Light crossbows":
           Player.transform.Find(weapon).gameObject.SetActive(true);
            break;
            case "Javelin":
           Player.transform.Find(weapon).gameObject.SetActive(true);
            break;
            case "Mace":
           Player.transform.Find(weapon).gameObject.SetActive(true);
            break;
            case "Club":
           Player.transform.Find(weapon).gameObject.SetActive(true);
            break;
            case "Longsword":
           Player.transform.Find(weapon).gameObject.SetActive(true);
            break;
        }
    }

}
