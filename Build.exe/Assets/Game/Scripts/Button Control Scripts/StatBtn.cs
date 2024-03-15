using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatBtn: MonoBehaviour
{
    public string StasName;
    [SerializeField]private string statsRoll;
    public GameObject StatsObject;

    void Start()
    {
        statsRoll=StatsObject.GetComponent<PlayerStatsRoll>().StatsName="";
    }
    public void onEdit()
    {
        statsRoll=StasName;
    }
    
}