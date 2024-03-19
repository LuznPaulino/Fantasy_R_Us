using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SkillsScriptBackground: MonoBehaviour
{
    private string B;
    public string Choice;

    public Dropdown dropdown;

    List<string> Skills = new List<string>{"Acrobatics","Animal Handling","Arcana","Athletics","Deception","History","Insight","Intimidation","Investigation","Medicine","Nature","Perception","Performance","Persuasion","Religion","Sleight of Hand","Stealth","Survival"};
    List <string> selectableSkills= new List<string>();
    List<string> skills;



    void Start()
    {
        string skillGameC= GameControl.control.skill;
        string skillClass= GameControl.control.skillClass;
        B = GameControl.control.Pbckgrnd;
       switch (B)
                {
                    case "Acolyte":
                    skills = new List<string>{"Insight","Religion"};
                    for(int j=0;j <skills.Count;j++)
                    {
                        if(skills[j] == skillGameC || skills[j]== skillClass){}
                        else{selectableSkills.Add(skills[j]);}
                    }
                    break;

                    case "Criminal":
                    skills = new List<string>{"Deception","Stealth"};
                    for(int j=0;j <skills.Count;j++)
                    {
                        if(skills[j] == skillGameC || skills[j]== skillClass){}
                        else{selectableSkills.Add(skills[j]);}
                    }
                    break;

                    case "Spy":
                    skills = new List<string>{"Deception","Stealth"};
                    for(int j=0;j <skills.Count;j++)
                    {
                        if(skills[j] == skillGameC || skills[j]== skillClass){}
                        else{selectableSkills.Add(skills[j]);}
                    }
                    break;

                    case "Folk Hero":
                    skills = new List<string>{"Animal Handling","Survival"};
                    for(int j=0;j <skills.Count;j++)
                    {
                        if(skills[j] == skillGameC || skills[j]== skillClass){}
                        else{selectableSkills.Add(skills[j]);}
                    }
                    break;

                    case "Noble":
                    skills = new List<string>{"History","Persuasion"};
                    for(int j=0;j <skills.Count;j++)
                    {
                        if(skills[j] == skillGameC || skills[j]== skillClass){}
                        else{selectableSkills.Add(skills[j]);}
                    }
                    break;

                    case "Sage":
                    skills = new List<string>{"History","Arcana"};
                    for(int j=0;j <skills.Count;j++)
                    {
                        if(skills[j] == skillGameC || skills[j]== skillClass){}
                        else{selectableSkills.Add(skills[j]);}
                    }
                    break;

                    case "Soldier":
                    skills = new List<string>{"Athletics","Intimidation"};
                    for(int j=0;j <skills.Count;j++)
                    {
                        if(skills[j] == skillGameC || skills[j]== skillClass){}
                        else{selectableSkills.Add(skills[j]);}
                    }
                    break;

                }
        Clear();
        GameControl.control.skillBckgrnd= dropdown.options[0].text.ToString();
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
        GameControl.control.skillBckgrnd=Choice;
        break;
        case "Animal Handling":
        GameControl.control.skillBckgrnd=Choice;
        break;
        case "Arcana":
        GameControl.control.skillBckgrnd=Choice;
        break;
        case "Athletics":
        GameControl.control.skillBckgrnd=Choice;
        break;
        case "Deception":
        GameControl.control.skillBckgrnd=Choice;
        break;
        case "History":
        GameControl.control.skillBckgrnd=Choice;
        break;
        case "Insight":
        GameControl.control.skillBckgrnd=Choice;
        break;
        case "Intimidation":
        GameControl.control.skillBckgrnd=Choice;
        break;
        case "Investigation":
        GameControl.control.skillBckgrnd=Choice;
        break;
        case "Medicine":
        GameControl.control.skillBckgrnd=Choice;
        break;
        case "Nature":
        GameControl.control.skillBckgrnd=Choice;
        break; 
        case "Perception":
        GameControl.control.skillBckgrnd=Choice;
        break;
        case "Performance":
        GameControl.control.skillBckgrnd=Choice;
        break;
        case "Persuasion":
        GameControl.control.skillBckgrnd=Choice;
        break;
        case "Religion":
        GameControl.control.skillBckgrnd=Choice;
        break;
        case "Sleight of Hand":
        GameControl.control.skillBckgrnd=Choice;
        break;
        case "Stealth":
        GameControl.control.skillBckgrnd=Choice;
        break;
        case "Survival":
        GameControl.control.skillBckgrnd=Choice;
        break;
      }
   }
}
