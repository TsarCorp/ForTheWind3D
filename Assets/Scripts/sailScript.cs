using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sailScript : MonoBehaviour
{

    public AudioSource audioSource1;
    public AudioSource audioSource2;

    public Sprite sailSprite0;
    public Sprite sailSprite1;
    public Sprite sailSprite2;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (PlayerController.sailState == 0)
        {
            GetComponent<Image>().sprite = sailSprite0;
        }

        if (PlayerController.sailState == 1)
        {
            GetComponent<Image>().sprite = sailSprite1;
        }

        if (PlayerController.sailState == 2)
        {
            GetComponent<Image>().sprite = sailSprite2;
        }


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
