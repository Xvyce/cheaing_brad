using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ConeLOS : MonoBehaviour
{
    public float playRate = 1;
    private float nextPlayTime = 0;
    public ParticleSystem particle; // !

    bool isSpotted;
    
    void Start()
    {
        isSpotted = false;
        particle.GetComponent<ParticleSystem>(); 
        var em = particle.emission;
        em.enabled = false;
    }


    // Update is called once per frame
    void Update()
    {
        
        if(isSpotted == true)
        {
            FindObjectOfType<AudioManagerScript>().Play("Detected");
            isSpotted = false;
        }
        

    }
    void OnTriggerStay2D(Collider2D collision)
    {

            if (collision.gameObject.CompareTag("Player") && Movement.isSafe == false )
            {
                DetectionMeter.currentDetection += 8 * Time.deltaTime;
               // Destroy(Instantiate(Exclamationmark, transform.position, transform.rotation), 1);
            }
        
    }




    void OnTriggerEnter2D(Collider2D collision)
    { 
      if (collision.gameObject.CompareTag("Player") && Movement.isSafe == false)
            {
            isSpotted = true;
             particle.GetComponent<ParticleSystem>(); 
               var em = particle.emission;
               em.enabled = true;
                 StartCoroutine(stopParticles());
         }
    }

  IEnumerator stopParticles()
  {
      
   yield return new WaitForSeconds(.5f);  
   particle.GetComponent<ParticleSystem>(); 
        var em = particle.emission;
        em.enabled = false;

  }
}
