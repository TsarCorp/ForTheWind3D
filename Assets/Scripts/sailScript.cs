using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sailScript : MonoBehaviour
{

    public AudioSource audioSource1;
    public AudioSource audioSource2;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (PlayerController.sailState == 1)
        {
            //AudioSource audioSource1 = GetComponent<AudioSource>();
            audioSource1.Play();
        }

        if (PlayerController.sailState == 2)
        {
            //AudioSource audioSource2 = GetComponent<AudioSource>();
            audioSource2.Play();
        }
    }
}
