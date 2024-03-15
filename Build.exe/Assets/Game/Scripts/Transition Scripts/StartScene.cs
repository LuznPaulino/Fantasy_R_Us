using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Set Scene to the Character Menu
public class StartScene: MonoBehaviour
{
    public void SceneLoader()
    {
        SceneManager.LoadScene("Load");
    }
}
