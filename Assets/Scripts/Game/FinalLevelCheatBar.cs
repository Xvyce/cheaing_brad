﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class FinalLevelCheatBar : MonoBehaviour
{
    public Color startColor;
    public Color endColor;
    public GameManagement gameManagement;
//public Rewardsystem rewardsystem;
  //  public Collectibles collectible;



    //	public Color startScreenColor;//screendamage
    //  public Color endScreenColor;//screendamage

    [SerializeField]
    public static float maxHealth;
    public static float currentHealth;

    [SerializeField]
    protected SpriteRenderer spriteRenderer;

    public Image healthBar;
   /// public Image screenDamage;  //screendamage

    void Start()
    {
        //dps = 1.65f;
        currentHealth = 0;
    }

    protected virtual void Awake()
    {

        maxHealth = 30;
        spriteRenderer = GetComponent<SpriteRenderer>();
        currentHealth = maxHealth;
        if (healthBar != null)
            healthBar.fillAmount = 1.0f;
    }
    void Update()
    {

        TakeDamage();

        //if (currentHealth > maxHealth)
        //{
        //    currentHealth = maxHealth;
        //}
    }

    public void TakeDamage()
    {
        //if (Input.GetKey(KeyCode.Space))
        //    currentHealth += 5 * Time.deltaTime;



        if (healthBar != null)
            healthBar.fillAmount = currentHealth / maxHealth;

        if (currentHealth >= maxHealth)
        {

            SceneManager.LoadScene("GetCaught");

            // gameManagement.CompleteLevel;
        }
        //healthBar.GetComponent<Image>().color = Color.Lerp(endColor, startColor, healthBar.fillAmount);

        //screenDamage.GetComponent<Image>().color = Color.Lerp(endScreenColor, startScreenColor, healthBar.fillAmount);

        //if (currentHealth <= 0f)
        //    SceneManager.LoadScene("GameOver");
    }
}
