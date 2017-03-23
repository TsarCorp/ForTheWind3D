using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonAI : MonoBehaviour
{

    public GameObject spriteObject;
    private SpriteRenderer spriteComponent;

    public GameObject Projectile;
    public float projectileSpeed;

    public static float chargeL = 0f;
    public static float chargeR = 0f;
    public float spriteAlpha;
    public AudioClip[] cannonSounds;

    public bool fireLeft;
    public bool fireRight;

    public bool firingLeft = false;
    public bool firingRight = false;
    public bool firing = false;

    // Use this for initialization
    void Start()
    {
        spriteComponent = spriteObject.GetComponent<SpriteRenderer>();
        spriteAlpha = 0;
    }

    // Update is called once per frame
    void Update()
    {

        spriteComponent.color = new Color(1f, 1f, 1f, spriteAlpha);

        //fire left
        if (firingLeft)
        {
            chargeL++;
            spriteAlpha = spriteComponent.color.a;
            spriteAlpha += 0.005f;
        }

        if (firingRight)
        {
            chargeR++;
            spriteAlpha = spriteComponent.color.a;
            spriteAlpha += 0.005f;
        }


        if (!firingRight && !firingLeft)
        {
            spriteAlpha = spriteComponent.color.a;
            spriteAlpha = 0;
        }


        if (chargeL > 250)
        {

            chargeL = 0;
            for (int i = 0; i < AiController.cannonCount; i++)
            {
                var rTime = Random.Range(0.001f, 1f);
                Invoke("fire", rTime);
                spriteAlpha = 0;
            }
        }

        if (chargeR > 250)
        {

            chargeR = 0;
            for (int i = 0; i < AiController.cannonCount; i++)
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

        var randomPos = Random.Range(-0.5f, 0.5f);
        var localOffset = new Vector3(0.75f, randomPos, 0);
        var worldOffset = transform.rotation * localOffset;
        var spawnPosition = transform.position + worldOffset;

        GameObject cBall = Instantiate(Projectile, spawnPosition, spriteObject.transform.localRotation) as GameObject;

        //send projectile in the relative direction
        cBall.GetComponent<Rigidbody>().velocity = transform.right * projectileSpeed;
        AudioSource.PlayClipAtPoint(cannonSounds[Random.Range(0, cannonSounds.Length)], transform.position);
    }




    void OnTriggerStay(Collider other)
    {
        if (other.tag == "anyShip")
        {
            if (other.gameObject.GetComponent<Rigidbody>())
            {
                if (fireLeft)
                {
                    firingLeft = true;

                }

                if (fireRight)
                {
                    firingRight = true;

                }
            }
        }
    }


    void OnTriggerExit(Collider other)
    {
        firingLeft = false;
        firingRight = false;

    }

}
