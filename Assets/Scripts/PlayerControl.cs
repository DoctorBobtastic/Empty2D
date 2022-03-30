using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Rigidbody2D rb;

    float walkSpeed = 4f;
    float speedLimiter = 0.7f;
    float inputHorizontal;
    float inputVertical;

    //Animations and States
    Animator animator;
    string currentState;
    const string PLAYER_IDLE = "Player_Idle";

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();



    }

    // Update is called once per frame
    void Update()
    {
        //Movement Block
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        if(inputHorizontal !=0 || inputVertical != 0)
        {
            
            if(inputHorizontal != 0 && inputVertical != 0)
            {
                inputHorizontal *= speedLimiter;
                inputVertical *= speedLimiter;

            }
            
            rb.velocity = new Vector2(inputHorizontal*walkSpeed , inputVertical *walkSpeed);
        }
        else
        {
            rb.velocity = new Vector2(0f, 0f);
        }
    }

    void ChangeAnimationState(string newSate)
    {

    }

}
