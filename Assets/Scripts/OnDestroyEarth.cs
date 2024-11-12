using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class OnDestroyEarth : MonoBehaviour
{
    public static float health;
    public TMP_Text healthText;
    public void Update()
    {
        healthText.text = "Health: " + health;
    }
    void Start()
    {
        health = 100;
    }
    
    public void TakeDamage(float h)
    {
        health -= h;
        if (health <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Game Over");
        }

    }
}