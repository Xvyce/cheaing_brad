using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 2.0f;

    public static bool facingRight = true;


    public static bool isSafe = true;

    float objectWidth;
    float objectHeight;

    Rigidbody2D _rigidbody2D;

     public Animator animator;
    Vector2 movement;

    float horizontalMovement;
    float verticalMovement;

    void Start()
    {
        isSafe = true;
        facingRight = true;
        _rigidbody2D = GetComponent<Rigidbody2D>();
        
        objectWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
    }

    
    void FixedUpdate()
    {
      
        
        horizontalMovement = Input.GetAxis("Horizontal") * moveSpeed;
        verticalMovement = Input.GetAxis("Vertical") * moveSpeed;
        
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

         _rigidbody2D.velocity = Vector3.zero;
        _rigidbody2D.velocity = new Vector2(horizontalMovement, verticalMovement);
      

         animator.SetFloat("Horizontal", horizontalMovement);
        animator.SetFloat("Vertical", verticalMovement);
        animator.SetFloat("speed", movement.sqrMagnitude);
        //  animator.SetFloat("Speedx", Mathf.Abs(horizontalMovement.x));
        // animator.SetFloat("Speedy", Mathf.Abs(verticalMovement.y));
        //_rigidbody2D.MovePosition(_rigidbody2D.position * movement *moveSpeed *Time.fixedDeltaTime);
       

        RestrictMovement();
    }
    void Update()
    {
        
       // FlipCheck();

    }
    void FlipCheck()
    {
        if (facingRight == false && horizontalMovement > 0)
        {
            Flip();
        }
        else if (facingRight == true && horizontalMovement < 0)
        {
            Flip();
        }
    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
    void RestrictMovement()
    {
        Vector3 upperRightCorner = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0));
        Vector3 lowerLeftCorner = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));

        float restrictedX = Mathf.Clamp(transform.position.x, lowerLeftCorner.x + objectWidth, upperRightCorner.x - objectWidth);
        float restrictedY = Mathf.Clamp(transform.position.y, lowerLeftCorner.y + objectHeight, upperRightCorner.y - objectHeight);

        transform.position = new Vector3(restrictedX, restrictedY, 0);
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("safeZone"))
        {
            isSafe = true;
        }
        else
            isSafe = false;
    }
}
