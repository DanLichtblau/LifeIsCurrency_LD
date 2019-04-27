using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 2.4f;

    private Rigidbody2D playerRB;
    private Animator playerAnim;
    private float goXScale;

    public bool canJump = true;
    public bool isGrounded; 

    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerAnim = GetComponentInChildren<Animator>();
        goXScale = transform.localScale.x;
        isGrounded = true;
    }

    void Update()
    {
        HandleMovement();
    }

    void HandleMovement()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        Vector3 moveDir = new Vector3(horizontalMovement, 0, 0);
       

        if(isGrounded == true)
        {
            gameObject.transform.Translate(moveDir * speed * Time.deltaTime);

            if (horizontalMovement > 0)
            {
                playerAnim.SetBool("IsRunning", true);
                transform.localScale = new Vector3(goXScale, transform.localScale.y, transform.localScale.z);
            }
            if (horizontalMovement < 0)
            {
                playerAnim.SetBool("IsRunning", true);
                transform.localScale = new Vector3(-goXScale, transform.localScale.y, transform.localScale.z);
            }

            if (horizontalMovement == 0)
            {
                playerAnim.SetBool("IsRunning", false);
            }

            //jumping
            if (Input.GetKeyDown(KeyCode.Space))
            {
                playerRB.AddForce(new Vector2(moveDir.x * 150, 2 * 120));
            }

        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
            playerAnim.SetBool("IsRunning", false);
        }
    }
}
