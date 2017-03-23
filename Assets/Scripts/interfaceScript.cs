using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interfaceScript : MonoBehaviour
{


    public string whichInterface;

    public GameObject InterfaceDock;
    public GameObject InterfaceTown;
    public GameObject InterfaceCity;
    public GameObject InterfaceFort;
    public GameObject InterfaceFarm;
    public GameObject InterfaceBlackMarket;


    // Use this for initialization
    void Start()
    {
        killUI();
    }

    // Update is called once per frame
    void Update()
    {
        //killUI();
    }

    void killUI()
    {
        InterfaceDock.gameObject.SetActive(false);
        InterfaceTown.gameObject.SetActive(false);
        InterfaceCity.gameObject.SetActive(false);
        InterfaceFort.gameObject.SetActive(false);
        InterfaceFarm.gameObject.SetActive(false);
        InterfaceBlackMarket.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.GetComponent<Rigidbody>())
        {
            //    other.attachedRigidbody.AddForce(Vector3.up * 10);
            //print(roomInterface);
            //if (PlayerController.sailState == 0) { 
            if (whichInterface == "dock") { InterfaceDock.gameObject.SetActive(true); }
            if (whichInterface == "town") { InterfaceTown.gameObject.SetActive(true); }
            if (whichInterface == "city") { InterfaceCity.gameObject.SetActive(true); }
            if (whichInterface == "fort") { InterfaceFort.gameObject.SetActive(true); }
            if (whichInterface == "farm") { InterfaceFarm.gameObject.SetActive(true); }
            if (whichInterface == "blackmarket") { InterfaceBlackMarket.gameObject.SetActive(true); }
            //} else { killUI();  }
        }
    }


    void OnTriggerExit(Collider other)
    {

        killUI();

    }





}
