using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClassScene : MonoBehaviour
{
    public Dropdown dropDown;

    public void SceneLoader()
    {
        SceneManager.LoadScene("Class");
    }
}
