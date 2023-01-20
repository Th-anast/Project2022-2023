using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseScreen;
    public static bool onPause;

    // Start is called before the first frame update
    void Start()
    {
        
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
    }

    void Pause()
    {
        onPause = true;
        pauseScreen.SetActive(onPause);
    }

    void Unpause()
    {
        onPause = false;
        pauseScreen.SetActive(onPause);
    }
}
