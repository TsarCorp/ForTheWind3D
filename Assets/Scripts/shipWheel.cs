using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipWheel : MonoBehaviour
{

    public static float targetDirection = 0;
    public GameObject shipObject;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        var shipDir = shipObject.transform.localEulerAngles[1];
        var wheelDir = transform.localEulerAngles[1];
        if (shipDir > 180) { shipDir -= 360; }
        if (wheelDir > 180) { wheelDir -= 360; }
      



        //the wheel script thing that doesn't quiet work - it turns with the ship at high speeds
        transform.Rotate(0, 0, wheelDir * Time.deltaTime);

        //targetDirection = transform.eulerAngles[1];




        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, 70 * Time.deltaTime);
            
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -70 * Time.deltaTime);
            
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            targetDirection = transform.eulerAngles[1];
            if (targetDirection > 180) { targetDirection -= 360; }
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            targetDirection = transform.eulerAngles[1];
            if (targetDirection > 180) { targetDirection -= 360; }
        }

        //print(targetDirection);
    }
}
