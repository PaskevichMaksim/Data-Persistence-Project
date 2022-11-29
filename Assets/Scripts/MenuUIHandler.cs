using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public static string name;
    public void GoToGame()
    {
        if (name != null)
        {
            SceneManager.LoadScene(1);
        }
    }

    public void ReadStringInput(string playerName)
    {
        name = playerName;
    }
}
