using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpellsScene : MonoBehaviour
{
    public void SceneLoader()
    {
        SceneManager.LoadScene("Spells");
    }
}
