﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    public float initialPlayerHealth;
    private float currentPlayerHealth;
    public Image healthBar;

    void Start()
    {
        currentPlayerHealth = initialPlayerHealth;
    }

    public void damage()
    {
        if (currentPlayerHealth > 0)
        {
            currentPlayerHealth -= 1f;
            healthBar.fillAmount = currentPlayerHealth / initialPlayerHealth;
        }

        if (currentPlayerHealth == 0)
        {
            GetComponent<Animator>().SetBool("playerDie", true);
            GetComponent<Collider>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
            Destroy(GameObject.Find("Rifle"));
        }

    }

    public float GetPlayerHealth()
    {
        return currentPlayerHealth;
    }
}