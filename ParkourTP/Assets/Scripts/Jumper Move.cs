using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumperMove : MonoBehaviour
{
    public float gravity;
    public Vector2 velocity;
    public float jumpVelocity=20;
    public float groundHeight=10;
    public bool isGrounded = false;
    
    public bool isHoldingJump = false;
    public float maxHoldJumpTime=0.4f;
    public float holdJumpTimer=0.0f;

    void Start()
    {
       
    }

    
    void Update()
    {
        
         if(isGrounded)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                isGrounded=false;
                velocity.y=jumpVelocity;
                isHoldingJump=true;
            }
        }

        if(Input.GetKeyUp(KeyCode.Space))
            {
                isHoldingJump=false;    
            }

    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;
        
        if(!isGrounded)
        {
            if(isHoldingJump)
            {
                holdJumpTimer += Time.fixedDeltaTime;

                if(holdJumpTimer >= maxHoldJumpTime)
                {
                    isHoldingJump= false;
                    holdJumpTimer=0.0f;
                }
            }
            pos.y += velocity.y * Time.fixedDeltaTime;

            if(!isHoldingJump)
            {
                velocity.y += gravity * Time.fixedDeltaTime;
            }

            if(pos.y <= groundHeight)
            {
                pos.y = groundHeight;
                isGrounded=true;
            }
        }

         transform.position = pos;
    }

   

}
