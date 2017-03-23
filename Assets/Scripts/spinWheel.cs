using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinWheel : MonoBehaviour {


   
    //public GameObject gameObject;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        
        var wheelDir = transform.localEulerAngles[1];
        if (wheelDir > 180) { wheelDir -= 360; }
        transform.Rotate(0, 0, wheelDir * Time.deltaTime*2);

       
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, 360 * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -360 * Time.deltaTime);

        }

    }
}
