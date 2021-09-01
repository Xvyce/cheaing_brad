using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isCheating : MonoBehaviour
{
    public float playRate = 1;
    private float nextPlayTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (collision.gameObject.CompareTag("Classmate"))
            {
                if (Time.time > nextPlayTime)
                {
                    nextPlayTime = Time.time + playRate;

                    FindObjectOfType<AudioManagerScript>().Play("Writing");
                }
                GameHealth.currentHealth += 5 * Time.deltaTime;
            }
        }
    }
}
