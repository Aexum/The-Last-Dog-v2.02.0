﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPpal : MonoBehaviour {

    public GameObject Player;

    void Start()
    {

        print(GameControl.check);
        print(GameControl.nivel);

        float x = PlayerPrefs.GetFloat("PlayerX");
        float y = PlayerPrefs.GetFloat("Playery");

        transform.position = new Vector2(x, y);
    }

    public void BtnNuevoJuego(string nivelNuevoJuego)
    {
        SceneManager.LoadScene(nivelNuevoJuego);
        Time.timeScale = 1;

        
    }

    public void BtnContinuar() {

      
        if (GameControl.check != 0 && GameControl.check < 3 && GameControl.nivel <= 1)
        {
            SceneManager.LoadScene("Escena2");
            Instantiate(Player, transform.position, Quaternion.identity);
            Time.timeScale = 1;
        }
        if (GameControl.check >= 3 && GameControl.check < 6 && GameControl.nivel == 2)
        {
            SceneManager.LoadScene("nivel2");
            Instantiate(Player, transform.position, Quaternion.identity);
            Time.timeScale = 1;
        }
        if (GameControl.check >= 6 && GameControl.check < 9 && GameControl.nivel == 3)
        {
            SceneManager.LoadScene("Escena2");
            Instantiate(Player, transform.position, Quaternion.identity);
            Time.timeScale = 1;
        }

    }

    public void BtnMute()
    {
        AudioListener.pause = !AudioListener.pause;
    }

 
    public void BtnSalirJuego()
    {
        Application.Quit();
    }
}
