using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rewardsystem : MonoBehaviour
{
    float timerScore;

    public float timefor1star;
    //public float timefor2star;
    public float timefor3star;

    public Text timerScoreText;
    public GameObject[] rewards;

    public GameObject YouGot;
    public GameObject collectible;
    //public Text YouGot;
    // Start is called before the first frame update

    void Start()
    {


    }


    public void timeAndStars()
    {
        if (Timer.timer >= timefor1star)
        {
            StartCoroutine(wait1_5());
            rewards[0].SetActive(true);

        }
        if (Timer.timer <= timefor1star && Timer.timer >= timefor3star)
        {
            StartCoroutine(wait1_5());
            rewards[0].SetActive(true);
            StartCoroutine(wait_10());
            rewards[1].SetActive(true);

        }
        if (Timer.timer <= timefor3star)
        {
            StartCoroutine(wait1_5());
            rewards[0].SetActive(true);
            rewards[1].SetActive(true);
            StartCoroutine(wait_10());
            rewards[2].SetActive(true);

        }

    }
    public void collectibleOn()
    {
        YouGot.SetActive(true);
        collectible.SetActive(true);
    }

    public void getTime()
    {
        Timer.startTimer = false;
        timerScore = PlayerPrefs.GetFloat("Timer");
        timerScoreText.text = "Time: " + timerScore.ToString("0") + "seconds";
    }

    public IEnumerator wait1_5() //not working
    {
        yield return new WaitForSeconds(2);
    }
    public IEnumerator wait_10()
    {
        yield return new WaitForSeconds(3);
    }
}
