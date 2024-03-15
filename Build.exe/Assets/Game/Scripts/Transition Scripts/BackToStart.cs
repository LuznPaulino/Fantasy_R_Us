using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToStart : MonoBehaviour
{
    public void BackStart()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
