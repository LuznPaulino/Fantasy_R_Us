using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScene : MonoBehaviour
{
    public void SceneLoader()
    {
        SceneManager.LoadScene("Intro");
    }
}
