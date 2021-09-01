using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DetectionMeter : MonoBehaviour
{
    public Color startColor;
    public Color endColor;
    public GameManagement gameManagement;
    //	public Color startScreenColor;//screendamage
    //  public Color endScreenColor;//screendamage
    public float playRate = 1;
    private float nextPlayTime = 0;


    [SerializeField]
    public static float maxDetection;
    public static float currentDetection;

    [SerializeField]
    protected SpriteRenderer spriteRenderer;

    public Image detectionBar;
  //  public Image screenDamage;  //screendamage

    void Start()
    {
        //dps = 1.65f;
        Time.timeScale = 1f;
        currentDetection = 0;
    }

    protected virtual void Awake()
    {

        maxDetection = 30;
        spriteRenderer = GetComponent<SpriteRenderer>();
        currentDetection = maxDetection;
        if (detectionBar != null)
            detectionBar.fillAmount = 1.0f;
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

        if (currentDetection >= maxDetection)
        {
            if (Time.time > nextPlayTime)
            {
                nextPlayTime = Time.time + playRate;
                
                FindObjectOfType<AudioManagerScript>().Play("FailSound");
            }
            
            gameManagement.CompleteLevel();
            Time.timeScale = 0f;
        }

        if (detectionBar != null)
            detectionBar.fillAmount = currentDetection / maxDetection;


        //healthBar.GetComponent<Image>().color = Color.Lerp(endColor, startColor, healthBar.fillAmount);

        //screenDamage.GetComponent<Image>().color = Color.Lerp(endScreenColor, startScreenColor, healthBar.fillAmount);

        //if (currentHealth <= 0f)
        //    SceneManager.LoadScene("GameOver");
    }
}
