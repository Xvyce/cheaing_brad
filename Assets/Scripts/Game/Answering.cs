using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Answering : MonoBehaviour
{
    public Color startColor;
    public Color endColor;

    public GameObject player;

    //	public Color startScreenColor;//screendamage
    //  public Color endScreenColor;//screendamage

    [SerializeField]
    public static float maxAnswer;
    public static float currentAnswer;

    [SerializeField]
    protected SpriteRenderer spriteRenderer;

    public Image healthBar;


    void Start()
    {
        //dps = 1.65f;
        currentAnswer = 0;
    }

    protected virtual void Awake()
    {

        maxAnswer = 50;
        spriteRenderer = GetComponent<SpriteRenderer>();
        currentAnswer = maxAnswer;
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
            healthBar.fillAmount = currentAnswer / maxAnswer;

        if (currentAnswer >= maxAnswer)
        {
            SceneManager.LoadScene("Graduation");
        }
        //healthBar.GetComponent<Image>().color = Color.Lerp(endColor, startColor, healthBar.fillAmount);

        //screenDamage.GetComponent<Image>().color = Color.Lerp(endScreenColor, startScreenColor, healthBar.fillAmount);

        //if (currentHealth <= 0f)
        //    SceneManager.LoadScene("GameOver");
    }
}
