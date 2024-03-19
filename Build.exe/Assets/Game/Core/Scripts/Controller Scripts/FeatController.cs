using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeatController : MonoBehaviour
{
    public string race;
    public GameObject YesFeats;
    public GameObject NoFeats;

    void Start()
    {
        race = GameControl.control.Prace;
        if (race == "Human")
        {
            YesFeats.SetActive(true);
            NoFeats.SetActive(false);
        }
        else
        {
            NoFeats.SetActive(true);
            YesFeats.SetActive(false);
        }
    }
}
