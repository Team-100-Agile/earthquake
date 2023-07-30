using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public Animator anim;
    public bool crouched;



    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        Time.timeScale= 1.0f;
    }



    // Update is called once per frame
    void Update()
    {
        if (rb.GetComponentInChildren<Impact>().gameover) return;


        anim.SetBool("run", false);
   

        if (Input.GetKey("down"))
        {

            anim.SetTrigger("crouch"); //start crouch animation
            crouched = true;
          
        }
        else
        {
            
           
            anim.ResetTrigger("crouch");

            if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1) //check if crouch animation has completed
            {
                crouched = false;

            }


        }


        if (crouched) return; //dont allow movement when crouch animation is still running

        if (Input.GetKey("left"))
        {

            rb.MovePosition(transform.position + new Vector3(-0.2f, 0, 0)); //move left
            anim.SetBool("run", true); // start run animation
            transform.rotation = Quaternion.Euler(8, -90, 0); //rotate character
        }

        if (Input.GetKey("right"))
        {

            rb.MovePosition(transform.position + new Vector3(0.2f, 0, 0)); //move right
            anim.SetBool("run", true);// start run animation
            transform.rotation = Quaternion.Euler(8, 90, 0);//rotate character
        }
    }

}