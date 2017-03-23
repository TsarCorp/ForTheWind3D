using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wakeScript : MonoBehaviour {

    public AudioSource audioSource1;
    public AudioSource audioSource2;


    // Use this for initialization
    void Start () {
      
    
    
        //psMain.startColor = Color.clear;
    }
	
	// Update is called once per frame
	void Update () {
	if (PlayerController.sailState > 0) {
            //AudioSource audioSource1 = GetComponent<AudioSource>();

            if (audioSource1.volume < 0.1f) { audioSource1.volume += 0.001f; }
            if (audioSource2.volume > 0f)   { audioSource2.volume -= 0.001f; }


        }
        else
        {
            //AudioSource audioSource1 = GetComponent<AudioSource>();
            if (audioSource1.volume > 0f)   { audioSource1.volume -= 0.001f; }
            if (audioSource2.volume < 0.1f) { audioSource2.volume += 0.001f; }
        }
       

	}
}
