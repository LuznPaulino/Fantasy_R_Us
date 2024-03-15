using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SkillsScriptClass: MonoBehaviour
{
    private string C;
    public string Choice;

    public Dropdown dropdown;

    List<string> Skills = new List<string>{"Acrobatics","Animal Handling","Arcana","Athletics","Deception","History","Insight","Intimidation","Investigation","Medicine","Nature","Perception","Performance","Persuasion","Religion","Sleight of Hand","Stealth","Survival"};
    List <string> selectableSkills= new List<string>();
    List<string> skills;



    void Start()
    {
        C = GameControl.control.Pclass;
        string GameCSkill= GameControl.control.skill;
       switch (C)
        {
            case "Barbarian":
                skills = new List<string>{"Animal Handling","Athletics","Intimidation","Nature","Perception","Survival"};
                for(int j=0;j <skills.Count;j++)
                {
                    if(skills[j] == GameCSkill){}
                    else{selectableSkills.Add(skills[j]);}
                }
                break;

                    case "Bard":
                    skills = new List<string>{"Acrobatics","Animal Handling","Arcana","Athletics","Deception","History","Insight","Intimidation","Investigation","Medicine","Nature","Perception","Performance","Persuasion","Religion","Sleight of Hand","Stealth","Survival"};
                    for(int j=0;j <skills.Count;j++)
                    {
                        if(skills[j] == GameCSkill){}
                        else{selectableSkills.Add(skills[j]);}
                    }
                    break;

                    case "Cleric":
                    skills = new List<string>{"History","Insight","Medicine","Persuasion","Religion"};
                    for(int j=0;j <skills.Count;j++)
                    {
                        if(skills[j] == GameCSkill){}
                        else{selectableSkills.Add(skills[j]);}
                    }
                    break;

                    case "Druid":
                    skills = new List<string>{"Arcana","Insight","Medicine","Perception","Religion","Animal Handling","Nature","Survival"};
                    for(int j=0;j <skills.Count;j++)
                    {
                        if(skills[j] == GameCSkill){}
                        else{selectableSkills.Add(skills[j]);}
                    }
                    break;

                    case "Ranger":
                    skills = new List<string>{"Animal Handling","Athletics","Medicine","Perception","Insight","Investigation","Nature","Survival","Stealth"};
                    for(int j=0;j <skills.Count;j++)
                    {
                        if(skills[j] == GameCSkill){}
                        else{selectableSkills.Add(skills[j]);}
                    }
                    break;

                    case "Rogue":
                    skills = new List<string>{"Acobatics","Athletics","Deception","Insight","Intimidation","Investigation","Perception","Performance","Persuasion","Sleight of Hand","Stealth"};
                    for(int j=0;j <skills.Count;j++)
                    {
                        if(skills[j] == GameCSkill){}
                        else{selectableSkills.Add(skills[j]);}
                    }
                    break;

                    case "Sorcerer":
                    skills = new List<string>{"Arcana","Deception","Insight","Intimidation","Religion","Persuasion"};
                    for(int j=0;j <skills.Count;j++)
                    {
                        if(skills[j] == GameCSkill){}
                        else{selectableSkills.Add(skills[j]);}
                    }
                    break;

                    case "Warlock":
                    skills = new List<string>{"Arcana","Deception","History","Intimidation","Investigation","Nature","Religion"};
                    for(int j=0;j <skills.Count;j++)
                    {
                        if(skills[j] == GameCSkill){}
                        else{selectableSkills.Add(skills[j]);}
                    }
                    break;

                    case "Wizard":
                    skills = new List<string>{"Arcana","History","Insight","Investigation","Religion","Medicine"};
                    for(int j=0;j <skills.Count;j++)
                    {
                        if(skills[j] == GameCSkill){}
                        else{selectableSkills.Add(skills[j]);}
                    }
                    break;

                }
        Clear();
        GameControl.control.skillClass = dropdown.options[0].text.ToString();
    }
    void Clear()
    {
        dropdown.ClearOptions();
        dropdown.AddOptions(selectableSkills);
    }
     public void DropDownSelection()
    {

      Choice = dropdown.options[dropdown.value].text;

      switch (Choice)
      {
        case "Acrobatics":
        GameControl.control.skillClass=Choice;
        break;
        case "Animal Handling":
        GameControl.control.skillClass=Choice;
        break;
        case "Arcana":
        GameControl.control.skillClass=Choice;
        break;
        case "Athletics":
        GameControl.control.skillClass=Choice;
        break;
        case "Deception":
        GameControl.control.skillClass=Choice;
        break;
        case "History":
        GameControl.control.skillClass=Choice;
        break;
        case "Insight":
        GameControl.control.skillClass=Choice;
        break;
        case "Intimidation":
        GameControl.control.skillClass=Choice;
        break;
        case "Investigation":
        GameControl.control.skillClass=Choice;
        break;
        case "Medicine":
        GameControl.control.skillClass=Choice;
        break;
        case "Nature":
        GameControl.control.skillClass=Choice;
        break; 
        case "Perception":
        GameControl.control.skillClass=Choice;
        break;
        case "Performance":
        GameControl.control.skillClass=Choice;
        break;
        case "Persuasion":
        GameControl.control.skillClass=Choice;
        break;
        case "Religion":
        GameControl.control.skillClass=Choice;
        break;
        case "Sleight of Hand":
        GameControl.control.skillClass=Choice;
        break;
        case "Stealth":
        GameControl.control.skillClass=Choice;
        break;
        case "Survival":
        GameControl.control.skillClass=Choice;
        break;
      }
   }
}
