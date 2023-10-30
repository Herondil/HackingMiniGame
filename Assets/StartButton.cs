using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    private void Start()
    {
        //au lancement du jeu, la scène est en pause
        Time.timeScale = 0.0f;
    }

    public void StopPause()
    {
        Time.timeScale = 1f;
    }
}
