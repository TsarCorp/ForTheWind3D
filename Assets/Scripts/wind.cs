using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wind : MonoBehaviour
{

    public static float windDir;
    public static float windStrength;

    // Use this for initialization
    void Start()
    {

        windDir = Random.Range(0, 360);
        windStrength = Random.Range(0.01f, 0.01f);

    }

    // Update is called once per frame
    void Update()
    {

        //randomDir = Time.deltaTime * Random.Range(randomDir - 1, randomDir + 1);
        windDir = Random.Range(windDir - 1, windDir + 1);
        windStrength = Random.Range(windStrength - 0.01f, windStrength + 0.01f);
        windStrength = Mathf.Clamp(windStrength, 0f, 0.1f);
        //print(windStrength);

    }
}
