using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeacherMove : MonoBehaviour
{
    [SerializeField] public List<Vector2> position = new List<Vector2>();

    // Start is called before the first frame update
    public Animator animator;

    [SerializeField] Vector2 movement;
    public float speed = 1.0f;
    private void Start()
    {
        Vector2 test = position[0]; // List no.1
        Vector2 test2 = position[1]; // List no.2


    }


    void Update()
    {
        //movement.x = transform.position.x;
        //animator.SetFloat("Horizontal",); //-1 is left , 1 is right
        // animator.SetFloat("Vertical",); // -1 is down , 1 is top
        //  animator.SetFloat("Speed",);
        // if (this.gameObject.transform.position == pos2)
        // {

        //     goingup = true;
        //     goingdown = false;
        // }
        // if(goingup == true)
        // {
        //     ChangeSpriteBack();
        // }
        // if (this.gameObject.transform.position == pos1)
        // {
        //     goingup = false;
        //     goingdown = true;
        // }
        // if (goingdown == true)
        // {
        //     ChangeSpriteFront();
        // }
       //transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
        



    }

    //IEnumerator Move()
    //{
    //    while (true)
    //    {
    //        transform.position = Vector3.Lerp(pos1, pos2, 3 * Time.time * speed);
    //        yield return new WaitForSeconds(2);
    //        transform.position = Vector3.Lerp(pos2, pos1, 3 * Time.time * speed);
    //    }
    //}

    // void ChangeSpriteBack()
    // {
    //     spriteRenderer.sprite = FacingBack;
    // }
    // void ChangeSpriteFront()
    // {
    //     spriteRenderer.sprite = FacingFront;
    // }

}
