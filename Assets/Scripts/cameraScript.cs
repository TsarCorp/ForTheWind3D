using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{

    public GameObject playerObject;
    public float camHeight;
    

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        camHeight += Input.GetAxis("Mouse ScrollWheel")*10;
        camHeight = Mathf.Clamp(camHeight, 6, 640);//prevents value from exceeding specified range
        //Debug.Log(camHeight);

        transform.position = new Vector3(playerObject.transform.position.x, playerObject.transform.position.y + camHeight, playerObject.transform.position.z);

        if (camHeight <= 4)
        {


            // transform.Rotate(0, 90, 0);
            transform.eulerAngles = new Vector3(90, 90, 0);

        }        else        {
            transform.eulerAngles = new Vector3(90, 0, 0);
        }
    }
}

