using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject pauseUI;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if(Time.timeScale == 1)
            {
                Time.timeScale = 0;
                pauseUI.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                pauseUI.SetActive(false);
            }
        }
    }
}
