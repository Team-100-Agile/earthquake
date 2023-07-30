using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Impact : MonoBehaviour
{
    // Start is called before the first frame update

    public Text text;
    public bool gameover;
    public Animator anim;
    AudioSource audio1;

    private void Awake()
    {
        audio1 = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("gameobject1"))
        {
            text.gameObject.SetActive(true);
           
            StartCoroutine(pause());


        }
        
    }
    IEnumerator pause()
    {

        anim.SetBool("pain", true);
        audio1.Play();
        gameover = true;
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    }