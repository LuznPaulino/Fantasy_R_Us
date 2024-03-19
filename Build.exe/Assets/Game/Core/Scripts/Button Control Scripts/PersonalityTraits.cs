
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonalityTraits : MonoBehaviour
{
    public void Flaws(string flaw)
    {
        GameControl.control.flaws = flaw;
    }

    public void Bonds(string bond)
    {
        GameControl.control.bonds = bond;
    }
}
