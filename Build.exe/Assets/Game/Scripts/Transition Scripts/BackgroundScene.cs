using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundScene : MonoBehaviour
{
    public void SceneLoader()
    {
        SceneManager.LoadScene("Background");
    }
}
