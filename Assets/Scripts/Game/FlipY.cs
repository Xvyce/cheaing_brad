using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipY : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Turn"))
        {
            transform.localRotation = transform.localRotation *= Quaternion.Euler(0, 0, 180);
            transform.position = new Vector3(0, -11, 0);

        }
    }
}
