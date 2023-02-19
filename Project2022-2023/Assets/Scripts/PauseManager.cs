using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEditor;
using Unity.VisualScripting;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseScreen;
    public CinemachineBrain cinemachineBrain;
    public static bool onPause;
    float previousTimeScale;

    // Start is called before the first frame update
    void Start()
    {
        previousTimeScale = Time.timeScale;
        onPause = false;
        pauseScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (!onPause)
            {
                Pause();                
            }
            else
            {
                Unpause();
            }
        }
        if (Input.GetKeyUp(KeyCode.Delete) && onPause)
        {
            Debug.Log("Quit");
            Application.Quit();
        }
    }

    void Pause()
    {
        onPause = true;
        pauseScreen.SetActive(onPause);
        cinemachineBrain.enabled = !onPause;
        previousTimeScale = Time.timeScale;
        AudioSource[] audios = FindObjectsOfType<AudioSource>();
        foreach (AudioSource a in audios) {
            a.Pause();
        }
        Time.timeScale = 0f;
    }

    void Unpause()
    {
        onPause = false;
        pauseScreen.SetActive(onPause);
        cinemachineBrain.enabled = !onPause;        
        AudioSource[] audios = FindObjectsOfType<AudioSource>();
        foreach (AudioSource a in audios) {
            a.UnPause();
        }
        Time.timeScale = previousTimeScale;
    }
}
