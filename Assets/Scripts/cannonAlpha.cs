using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonAlpha : MonoBehaviour {

    public GameObject spriteObject;
    private SpriteRenderer spriteComponent;
    public KeyCode assignedKey;
    public GameObject projectile;
    public float projectileSpeed;

    public static float charge = 0f;
    public float spriteAlpha;
    public AudioClip[] cannonSounds;

    // Use this for initialization
    void Start () {
        spriteComponent = spriteObject.GetComponent<SpriteRenderer>();
        
        spriteAlpha = 0;
        


    }

    // Update is called once per frame
    void Update () {

        spriteComponent.color = new Color(1f, 1f, 1f, spriteAlpha);


        //fire left
        if (Input.GetKey(assignedKey))
        {
            charge++;
            spriteAlpha = spriteComponent.color.a;
            spriteAlpha+=0.005f;

        }

        if (Input.GetKeyUp(assignedKey))
        {
            charge = 0;
            spriteAlpha = spriteComponent.color.a;
            spriteAlpha = 0;
        }

        

        if (charge > 250)
        {
            charge = 0;
            for (int i = 0; i < PlayerController.cannonCount; i++)
            {
                var rTime = Random.Range(0.001f, 1f);
                Invoke("fire", rTime);
                spriteAlpha = 0;
            }
        }


    }

    void fire()
    {
        //set projectile position to spread them out along the ship
        var randomPos = Random.Range(-0.5f , 0.5f);
        var localOffset = new Vector3(0.75f, randomPos, 0);
        var worldOffset = transform.rotation * localOffset;
        var spawnPosition = transform.position + worldOffset;

        GameObject cBall = Instantiate(projectile, spawnPosition, spriteObject.transform.localRotation) as GameObject;

        //send projectile in the relative direction
        cBall.GetComponent<Rigidbody>().velocity = transform.right * projectileSpeed; 
        AudioSource.PlayClipAtPoint(cannonSounds[Random.Range(0, cannonSounds.Length)], transform.position);
        

    }


}
