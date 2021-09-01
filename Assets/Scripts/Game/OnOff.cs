using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOff : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = true;
        gameObject.GetComponent<PolygonCollider2D>().enabled = true;
        StartCoroutine(Off());


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        
        

    }
    IEnumerator Off()
    {

        while (true)
        {
            yield return new WaitForSeconds(2);
            //   gameObject.GetComponent<Renderer>().enabled = false;
            gameObject.GetComponent<Renderer>().enabled = false;
            gameObject.GetComponent<PolygonCollider2D>().enabled = false;
            yield return new WaitForSeconds(2);
            gameObject.GetComponent<Renderer>().enabled = true;
            gameObject.GetComponent<PolygonCollider2D>().enabled = true;
        }


    }

}
