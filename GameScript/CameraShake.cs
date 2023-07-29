using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraShake : MonoBehaviour
{
    public float magnitude;
    AudioSource audio1;

    private void Awake()
    {
        audio1 = GetComponent<AudioSource>();

        if (SceneManager.GetActiveScene().buildIndex == 2 || SceneManager.GetActiveScene().buildIndex == 1) 
        {
            
            audio1.Play();
        
        }
    }
    // Update is called once per frame
    void Update()
    {
        float x = Random.Range(-1f, 1f) * magnitude;
       



        transform.position = new Vector3(x, transform.position.y,transform.position.z);
       
      
    
      
    }
}
