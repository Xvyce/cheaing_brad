using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    public static bool gotItem = false;
    // Start is called before the first frame update
    void Start()
    {
        gotItem = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<AudioManagerScript>().Play("collected");
            GameHealth.currentHealth += 7;
            gotItem = true;
            this.gameObject.SetActive(false);
        }
    }
}
