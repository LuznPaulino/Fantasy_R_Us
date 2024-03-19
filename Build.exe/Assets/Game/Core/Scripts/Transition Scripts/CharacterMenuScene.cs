using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterMenuScene : MonoBehaviour
{
    public void SceneLoader()
    {
        SceneManager.LoadScene("Character Menu");
    }
}
