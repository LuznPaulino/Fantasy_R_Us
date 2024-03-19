using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillsScriptRace : MonoBehaviour
{
    private string R;
    public string Choice;

    public Dropdown dropdown;

    List<string> Skills = new List<string> { "Acrobatics", "Animal Handling", "Arcana", "Athletics", "Deception", "History", "Insight", "Intimidation", "Investigation", "Medicine", "Nature", "Perception", "Performance", "Persuasion", "Religion", "Sleight of Hand", "Stealth", "Survival" };
    List<string> selectableSkills = new List<string>();
    List<string> skills;

    void Start()
    {
        R = GameControl.control.Prace;
        switch (R)
        {
            case "Dwarf":
                selectableSkills.Add("History");
                break;

            case "Elf":
                selectableSkills.Add("Perception");
                break;

            case "Half-Orc":
                selectableSkills.Add("Intimidation");
                break;
        }
        Clear();
        GameControl.control.skill = dropdown.options[0].text.ToString();
    }

    void Clear()
    {
        dropdown.ClearOptions();
        dropdown.AddOptions(selectableSkills);
    }
    public void DropDownSelection()
    {
        dropdown.ClearOptions();
        dropdown.AddOptions(selectableSkills);

        Choice = dropdown.options[dropdown.value].text;

        switch (Choice)
        {
            case "Acrobatics":
                GameControl.control.skill = Choice;
                break;
            case "Animal Handling":
                GameControl.control.skill = Choice;
                break;
            case "Arcana":
                GameControl.control.skill = Choice;
                break;
            case "Athletics":
                GameControl.control.skill = Choice;
                break;
            case "Deception":
                GameControl.control.skill = Choice;
                break;
            case "History":
                GameControl.control.skill = Choice;
                break;
            case "Insight":
                GameControl.control.skill = Choice;
                break;
            case "Intimidation":
                GameControl.control.skill = Choice;
                break;
            case "Investigation":
                GameControl.control.skill = Choice;
                break;
            case "Medicine":
                GameControl.control.skill = Choice;
                break;
            case "Nature":
                GameControl.control.skill = Choice;
                break;
            case "Perception":
                GameControl.control.skill = Choice;
                break;
            case "Performance":
                GameControl.control.skill = Choice;
                break;
            case "Persuasion":
                GameControl.control.skill = Choice;
                break;
            case "Religion":
                GameControl.control.skill = Choice;
                break;
            case "Sleight of Hand":
                GameControl.control.skill = Choice;
                break;
            case "Stealth":
                GameControl.control.skill = Choice;
                break;
            case "Survival":
                GameControl.control.skill = Choice;
                break;
        }
    }
}