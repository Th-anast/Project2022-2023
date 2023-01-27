using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("Quit!!!");
        Application.Quit();
    }
}
