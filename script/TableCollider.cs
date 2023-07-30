using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TableCollider : MonoBehaviour
{

    public GameObject player;
    public Text text;
    bool inside;


    private void Update()
    {
        if(inside && player.GetComponent<PlayerMovement>().crouched)
        {
           
            text.gameObject.SetActive(true);
            
            StartCoroutine(pause());
            

        }
    }

    IEnumerator pause()
    {

        yield return new WaitForSeconds(0.3f);
        player.GetComponentInChildren<Animator>().enabled = false;
        
        yield return new WaitForSeconds(3f);
       

        if (SceneManager.GetActiveScene().buildIndex== 2 ) 
        {
           
            SceneManager.LoadScene(0);

        }
        else 
        {
          
            SceneManager.LoadScene(2);


        }
       
    }


    private void OnTriggerEnter(Collider other)
    {
   
        if (other.gameObject == player)
        {
            
            inside = true;
        }
           
            


        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            inside = false;
        }
    }



}

