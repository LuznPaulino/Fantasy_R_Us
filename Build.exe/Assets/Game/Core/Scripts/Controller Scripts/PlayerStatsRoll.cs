using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/*
    Script is used to set up the Stats in the beginning of the game 
*/

public class PlayerStatsRoll : MonoBehaviour 
{
    public static PlayerStatsRoll rollStat;
    private List<int> roll= new List<int>(6);
    //private int i=0;
    public string StatsName;
    public Text[] stats;//Holds list of text fields for stats
    private List<int> mods= new List<int>();
    public Text[] modText;

    //private int stat=0;

    public GameObject controlObject;

    void Start()
    {
        controlObject=GameObject.FindGameObjectWithTag("GameController");
        controlObject.GetComponent<GameControl>();
        stats[0].text= GameControl.control.strength.ToString();
        stats[1].text= GameControl.control.dexterity.ToString();
        stats[2].text= GameControl.control.constitution.ToString();
        stats[3].text= GameControl.control.intelligence.ToString();
        stats[4].text= GameControl.control.wisdom.ToString();
        stats[5].text= GameControl.control.charisma.ToString();
        Mods();
    }
    public void PlayerStats()
    {
        for(int j=0;j<stats.Length;j++)
        {
            int rand = Random.Range(3, 19);
            switch (j)
            {
                case 0:
                    GameControl.control.strength = rand;
                    break;
                case 1:
                    GameControl.control.dexterity = rand;
                    break;
                case 2:
                    GameControl.control.constitution = rand;
                    break;
                case 3:
                    GameControl.control.intelligence = rand;
                    break;
                case 4:
                    GameControl.control.wisdom = rand;
                    break;
                case 5:
                    GameControl.control.charisma = rand;
                    break;
            }
            stats[j].text=rand.ToString(); //Fills TextField with a number
        
        }
        Mods();
    }


    //Mods that are dependent on PlayerStats outputs 
    public void Mods()
    {
        for(int x=0;x<stats.Length;x++)
        {
            int Stats = int.Parse(stats[x].text);
            if(Stats==3)
            {
                mods.Insert(x,-4);
            }
            if(Stats==4 || Stats==5)
            {
                mods.Insert(x,-3);
            }
            if(Stats==6 || Stats==7)
            {
               mods.Insert(x,-2);
            }
            if(Stats==8 || Stats==9)
            {
                mods.Insert(x,-1);
            }
            if(Stats==10 || Stats==11)
            {
                mods.Insert(x,-0);
            }
            if(Stats==12 || Stats==13)
            {
                mods.Insert(x,1);
            }
            if(Stats==14 || Stats==15)
            {
                mods.Insert(x,2);
            }
            if(Stats==16 || Stats==17)
            {
                mods.Insert(x,3);
            }
            if(Stats==18)
            {
                mods.Insert(x,4);
            }
            modText[x].text=mods[x].ToString();
        }
    }

    //These functions are for dice rolls 

    public int TwelveDie()
    {
        return Random.Range(1,13);
    }
    public int EightDie()
    {
        return Random.Range(1,9);
    }
    public int TenDie()
    {
        return Random.Range(1,11);
    }
    public int SixDie()
    {
        return Random.Range(1,7);
    }





}