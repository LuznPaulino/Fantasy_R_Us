using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is the class created to store the values
public class playerSave
{
    public int health = 100;
    public int mana = 100;
    public int strength = 10;
    public int dexterity = 10;
    public int constitution = 10;
    public int intelligence = 10;
    public int wisdom = 10;
    public int charisma = 10;

    public GameObject playermodel;
    public string Prace;
    public string Pclass;
    public string Psubrace;
    public string Pbckgrnd;
    public string Feats;
    public string Parmor;
    public string Pequip;
    public string flaws;
    public string bonds;

    public string Charname;
    public string CharAge;

    public string alignment;
    public string tProficiencies;
    public string sProficiences; // skill proficiences for the mods - luz
    public int ability;
    public string size;
    public string lang;
    public string skill; // what skill is this taking?? - luz 
    public string skillClass;
    public string skillBckgrnd;
    public int speed;
    public string[] spells;
    public string[] cantrips;
    public string[] skills; // general skills that are needed for the total skill set - luz
}
