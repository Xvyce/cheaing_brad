using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    public float speed;

    public bool MoveUp;
    [SerializeField]
    public GameObject FOV; //attached the field of view gameobject here 

    [SerializeField]
    public SpriteRenderer spriteRenderer;
    public Sprite FacingBack;
    public Sprite FacingFront;

    public float smooth = 1f;
    private Vector3 targetAngles;


    private void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

    }

    private void Update()
    {

       
        if (MoveUp)
        {
            transform.Translate(0, 2 * Time.deltaTime * speed, 0);
            ChangeSpriteBack();

        }
        else
        {

            transform.Translate(0, -2 * Time.deltaTime * speed, 0);
            ChangeSpriteFront();

        }

   
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Turn"))
        {
            if (MoveUp)
            {
                FOV.transform.rotation  *= Quaternion.Euler(0, 0, 180); //turns the field of view 180 degrees
                FOV.transform.position = gameObject.transform.position + new Vector3(0, -3.5f, 0); // put the turned fov but needs adjustment
                //FOV.transform.position = new Vector3(-3.35f, -1.9f, 0);
                MoveUp = false;
 
            }
            else
            {
                
                FOV.transform.rotation *= Quaternion.Euler(0, 0, 180);
                FOV.transform.position = gameObject.transform.position + new Vector3(0,5.5f,0);

                MoveUp = true;

            }
        }
    }


    void ChangeSpriteBack()
    {
        spriteRenderer.sprite = FacingBack;
    }
    void ChangeSpriteFront()
    {
        spriteRenderer.sprite = FacingFront;
    }

   
}
