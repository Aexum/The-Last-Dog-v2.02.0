﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver3 : MonoBehaviour
{

    private GameObject barravida;
    private GameObject Player;
    private GameObject Enemy;
    private GameObject Enemy2;
    private GameObject Enemy3;
    private GameObject Vida;

    private Animator player;

    private Rigidbody2D player1;
    private Rigidbody2D enemy1;

    private PlayerController playercontroller;
    private Rango rango;
    private PlayerAttack playerattack;
    private Bebe bebe;
    private Rugbier rug;



    // Use this for initialization
    void Start()
    {
        barravida = GameObject.Find("barravida");
        Player = GameObject.FindGameObjectWithTag("Player");
        Enemy = GameObject.FindGameObjectWithTag("Enemy");
        Enemy2 = GameObject.FindGameObjectWithTag("Enemy2");
        Enemy3 = GameObject.FindGameObjectWithTag("Enemy3");
        Vida = GameObject.FindGameObjectWithTag("Vida");

        player1 = Player.GetComponent<Rigidbody2D>();
        enemy1 = Enemy.GetComponent<Rigidbody2D>();

        player = Player.GetComponent<Animator>();

        playercontroller = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        rango = GameObject.Find("Zombie1").GetComponent<Rango>();
        playerattack = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerAttack>();
        bebe = GameObject.Find("Bebe1").GetComponent<Bebe>();


        barravida.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {


            gameObject.SetActive(false);
            Time.timeScale = 1f;

            playercontroller.enabled = true;
            rango.enabled = true;
            playerattack.enabled = true;
            bebe.enabled = true;

            player.SetBool("Revivir", true);
            player.SetBool("Dead", false);

            Enemy3.gameObject.GetComponent<BoxCollider2D>().enabled = true;
            Enemy2.gameObject.GetComponent<BoxCollider2D>().enabled = true;
            Enemy.gameObject.GetComponent<BoxCollider2D>().enabled = true;


            player1.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            player1.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;


            enemy1.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            enemy1.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;

            Enemy2.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            Enemy2.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;

            Enemy3.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            Enemy3.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;


            Player.transform.position = Player.GetComponent<PlayerController>().respawnPoint;


            barravida.SetActive(true);
            barravida.SendMessage("NoDamage", 100);

            SceneManager.LoadScene("nivel3");
        }
    }
}
