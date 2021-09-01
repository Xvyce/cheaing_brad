using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isStillCheating : MonoBehaviour
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
        if (Input.GetKey(KeyCode.Space))
        {
            if (collision.gameObject.CompareTag("Classmate"))
            {
                FinalLevelCheatBar.currentHealth += 5 * Time.deltaTime;
            }
        }
    }
}
