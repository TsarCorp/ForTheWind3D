using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiController : MonoBehaviour
{
    public GameObject primaryTarget;
    public GameObject secondaryTarget;
    public float health = 150f;
    private Rigidbody rb;
    public static float sailState = 1;
    public GameObject projectile;
    public AudioClip hitSound1;
    public AudioClip hitSound2;
    public AudioClip hitSound3;
    public static int cannonGroups = 1;
    public static int cannonCount = 4;
    public float speed;

    public static bool fireLeft = false;
    public static bool fireRight = false;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cannonCount = cannonGroups * 4;

        Vector3 pos = transform.position;
        primaryTarget = FindLastDock();
        secondaryTarget = FindFirstDock();

    }

    GameObject FindLastDock()
    {
        var dock = GameObject.FindGameObjectsWithTag("dock");
        GameObject furthest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;

        foreach (GameObject item in dock)
        {
            Vector3 diff = item.transform.position - position;
            float curDistance = diff.sqrMagnitude;

            if (curDistance < distance)
            {
                furthest = item;
                distance = curDistance;
            }
        }
        return furthest;
    }

    GameObject FindFirstDock()
    {
        var dock = GameObject.FindGameObjectsWithTag("dock");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;

        foreach (GameObject item in dock)
        {
            Vector3 diff = item.transform.position + position;
            float curDistance = diff.sqrMagnitude;

            if (curDistance < distance)
            {
                closest = item;
                distance = curDistance;
            }
        }
        return closest;
    }


    // Update is called once per frame
    void Update()
    {
        //getset Dir

        Vector3 vectorToTarget = primaryTarget.transform.position - transform.position;
        Vector3 facingDirection = transform.forward; // just for clarity!

        float angleInDegrees = Vector3.Angle(facingDirection, vectorToTarget);
        Quaternion rotation = Quaternion.FromToRotation(facingDirection, vectorToTarget);

        print (angleInDegrees);

        var relativeDirShip = transform.localEulerAngles[1];

        //steering
        speed = rb.velocity.magnitude / 10;
        if (relativeDirShip > 10)
        {
            rb.AddTorque(transform.up * speed / sailState);
            //print("left");
        }
        if (relativeDirShip < -10)
        {
            //print("right");
            rb.AddTorque(transform.up * -speed / sailState);
        }


        //sailMotion
        rb.AddForce(transform.forward * (0.1f * sailState));

        //windMotion
        var bearing2vector = Quaternion.Euler(0, wind.windDir, 0) * Vector3.forward * (wind.windStrength * sailState);
        rb.AddForce(bearing2vector);
    }

    void OnTriggerEnter(Collider collider)
    {
        projectile projectile = collider.gameObject.GetComponent<projectile>();
        if (collider.tag == "cannonBall")
        {
            if (projectile)
            {
                // Debug.Log("Projectile");
                health -= projectile.GetDamage();
                projectile.Hit();
                AudioSource.PlayClipAtPoint(hitSound1, transform.position);
                if (health <= 0)
                {
                    Die();
                }
            }
        }
    }

    void Die()
    {
        AudioSource.PlayClipAtPoint(hitSound1, transform.position);
        Destroy(gameObject);


    }

}
