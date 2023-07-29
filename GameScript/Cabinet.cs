using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cabinet : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    public float force;
    bool hitmaxforce;
    bool playernearby = false;
    public GameObject player;
    float addedforce=25f;
  

    void Awake()
    {

       

        rb = GetComponent<Rigidbody>();
        
    }

    void Update()
    {


        if (fallen())
        {

            rb.isKinematic = true; 
            rb.GetComponent<Collider>().enabled = false;
            //disable the cabinet's collider so it won't obstruct player's path
        }

        if (hitmaxforce) return; //stop adding force when it reaches its max force


        if (playernearby) 
        {

            rb.AddForce(transform.forward * force);
            force = force + addedforce;


        }
        if (force > 180)
        {
            hitmaxforce = true;
            playernearby = false;
        }


        if (Vector3.Distance(player.transform.position, transform.position) < 6f)
        {
            playernearby = true;
        }




    }

        private bool fallen()
        {
            return transform.eulerAngles.x == 90; 
        }
}

