using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isAnswering : MonoBehaviour
{
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

            if (collision.gameObject.CompareTag("safeZone"))
            {
               // GameHealth.currentHealth += 5 * Time.deltaTime;
                Answering.currentAnswer += 1.5f * Time.deltaTime;
            }

    }
}
