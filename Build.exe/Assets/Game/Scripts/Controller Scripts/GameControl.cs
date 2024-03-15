using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GameControl : MonoBehaviour
{
    public static GameControl control;
    
    //Gameplay varaibles
    public int health=100;
    public int mana=100;
    
    //Stat variables
    public int strength=10;
    public int dexterity=10;
    public int constitution=10;
    public int intelligence=10;
    public int wisdom=10;
    public int charisma=10;
    
    //Build-A-Player varaibles
    public GameObject playermodel;
    //--------------------------------------------------------
    public string Prace;
    public string Pclass;
    public string Psubrace;
    public string Pbckgrnd;
    public string Feats;
    public string Parmor;
    public string Pequip;
    public string flaws; // newest adding to the script
    public string bonds; // newest addings to the script 
    
    public string Charname;
    public string CharAge;
    
    //Extended Information
    public string alignment;
    public string tProficiencies;
    public int ability;
    public string size;
    public string lang;
    public string skill;
    public string skillClass;
    public string skillBckgrnd;
    public int speed;
    public string[] spells;
    public string[] cantrips;

    //Make sure there's only one instance of GameObject
    void Awake() 
    {
        if(control ==null)
        {
            DontDestroyOnLoad(gameObject);

            control = this;
        }
        else if(control !=this)
        {
            Destroy(gameObject);
        }   
    }
    void Start()
    {
        spells= new string[4];
        cantrips = new string[4];
        strength=10;
        dexterity=10;
        constitution=10;
        wisdom=10;
        charisma=10;
        intelligence = 10;
       
    }
    //This update is used on the Gameplay scene 
    void Update()
    {
        Scene scene= SceneManager.GetActiveScene();

        if(scene.name=="Gameplay")
        {
        
            GameObject healthPoints = GameObject.Find("Health Text");
            healthPoints.GetComponent<Text>().text = "Health: "+health.ToString();

            GameObject Mana = GameObject.Find("Mana Text");
            Mana.GetComponent<Text>().text = "Score: "+mana.ToString();

        }
    }

}
