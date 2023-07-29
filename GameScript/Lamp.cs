using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{

    public GameObject player;

    public Rigidbody rb;

    public float groundlevel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            rb.isKinematic = false;


        }

    }
    public void Update()
    {

        if (transform.position.y < groundlevel)
        {
            rb.isKinematic = true;
            rb.GetComponent<Collider>().enabled = false;

        }
    }
}
