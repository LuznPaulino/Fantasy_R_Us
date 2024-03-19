
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCharacter: MonoBehaviour
{
    public GameObject defaultModel;
    public static GameObject Pmodel;
    public string armor;
    public string weapon;
    private GameObject NewObject;
    private GameObject[] CHildTest;



    void Start()
    {
        Pmodel = GameControl.control.playermodel; // automatically picks the default model
        armor=GameControl.control.Parmor;
        weapon=GameControl.control.Pequip;
        if (Pmodel != null)
        {
            DestroyImmediate(defaultModel,true);
            NewObject =Instantiate(Pmodel,transform);
        }
        ArmorSet();
    }

   GameObject[] FindInActiveObjectByTag(string tag)
    {

    List<GameObject> validTransforms = new List<GameObject>();
    Transform[] objs = Resources.FindObjectsOfTypeAll<Transform>() as Transform[];
    for (int i = 0; i < objs.Length; i++)
    {
        if (objs[i].hideFlags == HideFlags.None)
        {
            if (objs[i].gameObject.CompareTag(tag))
            {
                    validTransforms.Add(objs[i].gameObject);
            }
        }
    }
        return validTransforms.ToArray();
    }

    void ArmorSet()
    {
        switch (armor)
        {
            case "Heavy armor":
            CHildTest=FindInActiveObjectByTag("HeavyArmor");
            foreach (GameObject item in CHildTest)
            {
                if(item.transform.IsChildOf(NewObject.transform))
                {
                    item.SetActive(true);
                }
            }
            break;
            case "Medium armor":
            CHildTest=FindInActiveObjectByTag("MediumArmor");
            foreach (GameObject item in CHildTest)
            {
                if(item.transform.IsChildOf(NewObject.transform))
                {
                    item.SetActive(true);
                }
            }
            break;
            case "Light armor":
            CHildTest=FindInActiveObjectByTag("LightArmor");
            foreach (GameObject item in CHildTest)
            {
                if(item.transform.IsChildOf(NewObject.transform))
                {
                    item.SetActive(true);
                }
            }
            break;
            case "Shields":
            CHildTest=FindInActiveObjectByTag("Shields");
            foreach (GameObject item in CHildTest)
            {
                if(item.transform.IsChildOf(NewObject.transform))
                {
                    item.SetActive(true);
                }
            }
            break;
            default:
            break;
        }
    }
    void Weapon()
    {
        switch (weapon)
        {
            case "Dagger":
            CHildTest=FindInActiveObjectByTag("Dagger");
            foreach (GameObject item in CHildTest)
            {
                if(item.transform.IsChildOf(NewObject.transform))
                {
                    item.SetActive(true);
                }
            }
            break;
            case "Hammer":
            CHildTest=FindInActiveObjectByTag("Hammer");
            foreach (GameObject item in CHildTest)
            {
                if(item.transform.IsChildOf(NewObject.transform))
                {
                    item.SetActive(true);
                }
            }
            break;
            case "Bow":
            CHildTest=FindInActiveObjectByTag("Bow");
            foreach (GameObject item in CHildTest)
            {
                if(item.transform.IsChildOf(NewObject.transform))
                {
                    item.SetActive(true);
                }
            }
            break;
            case "Staff":
            CHildTest=FindInActiveObjectByTag("Staff");
            foreach (GameObject item in CHildTest)
            {
                if(item.transform.IsChildOf(NewObject.transform))
                {
                    item.SetActive(true);
                }
            }
            break;
            case "Sword":
            CHildTest=FindInActiveObjectByTag("Sword");
            foreach (GameObject item in CHildTest)
            {
                if(item.transform.IsChildOf(NewObject.transform))
                {
                    item.SetActive(true);
                }
            }
            break;
            case "Spear":
            CHildTest=FindInActiveObjectByTag("Spear");
            foreach (GameObject item in CHildTest)
            {
                if(item.transform.IsChildOf(NewObject.transform))
                {
                    item.SetActive(true);
                }
            }
            break;
            default:
            CHildTest=FindInActiveObjectByTag("SpellBook");
            foreach (GameObject item in CHildTest)
            {
                if(item.transform.IsChildOf(NewObject.transform))
                {
                    item.SetActive(true);
                }
            }
            break;
        }
    }
}