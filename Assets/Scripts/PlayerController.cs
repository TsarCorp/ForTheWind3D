using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float speedMod;

    public static float health = 500f;
    private float seaRand;

    private Rigidbody rb;
    public ParticleSystem ps;
    public GameObject shipsWheel;
    public GameObject sailSprite;
    public static float sailState;

    public Sprite sailSprite0;
    public Sprite sailSprite1;
    public Sprite sailSprite2;

    public static int cannonGroups = 1;
    public static int cannonCount = 4;
    
    public GameObject projectile;
    public float projectileSpeed;

    public AudioClip hitSound1;
    public AudioClip hitSound2;
    public AudioClip hitSound3;

    public static int gold = 0;
    public static int cargo = 0;

    public static int cargoBrick = 0;
    public static int cargoLumber = 0;
    public static int cargoLivestock = 0;
    public static int cargoGrain = 0;
    public static int cargoOre = 0;
    public static int cargoCoin = 0;
    public static int cargoCloth = 0;
    public static int cargoBooks = 0;

    public static int Infamy = 0;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ps = GetComponent<ParticleSystem>();

        int gold = PlayerPrefs.GetInt("score", 0);
        int cargo = PlayerPrefs.GetInt("cargo", 0);

        cannonCount = cannonGroups * 4;
    }

    // START UPDATE
    void Update()
    {
        //print(cannonCount);
        seaMotion();
        windMotion();
        sailStuff();

        speed = rb.velocity.magnitude / 10;

        //sails up
        if (Input.GetKeyDown(KeyCode.W))
        {
            sailState++;
            if (sailState > 2) { sailState = 2; }

        }

        //steer left
        if (Input.GetKey(KeyCode.A))
        {
            // rb.AddTorque(transform.up * speedMod * -speed);


        }

        //sails down
        if (Input.GetKeyDown(KeyCode.S))
        {
            sailState--;
            if (sailState < 0) { sailState = 0; }
        }

        //steer right
        if (Input.GetKey(KeyCode.D))
        {
            // rb.AddTorque(transform.up * speedMod * speed);
        }

       

        
        //  END UPDATE
    }
    //  END UPDATE


        

    void windMotion()
    {
        var bearing2vector = Quaternion.Euler(0, wind.windDir, 0) * Vector3.forward * (wind.windStrength * sailState);

        rb.AddForce(bearing2vector);
    }


    void seaMotion()
    {
        seaRand = Random.Range(-1f, 1f);

        if (seaRand > 0)
        {
            rb.AddTorque(transform.up * 0.1f);
        }
        else
        {
            rb.AddTorque(transform.up * -0.1f);
        }
    }

    void sailStuff()
    {
        if (sailState == 0)
        {
            sailSprite.GetComponent<Image>().sprite = sailSprite0;
        }

        if (sailState == 1)
        {
            sailSprite.GetComponent<Image>().sprite = sailSprite1;
        }

        if (sailState == 2)
        {
            sailSprite.GetComponent<Image>().sprite = sailSprite2;
        }

        //some stuff 

        var relativeDirWheel = shipsWheel.transform.localEulerAngles[1];
        var dirWheel = shipsWheel.transform.eulerAngles[1];
        //convert from 0 360 to -180 180
        if (relativeDirWheel > 180) { relativeDirWheel -= 360; }



        //check if sails then apply forward -- if sail==0 then force is 0 anyway so removed check for now
        rb.AddForce(transform.forward * (0.1f * sailState));

        if (sailState > 0)
        {
            if (relativeDirWheel > 10)
            {
                rb.AddTorque(transform.up * speed / sailState);
                //print("left");
            }
            if (relativeDirWheel < -10)
            {
                //print("right");
                rb.AddTorque(transform.up * -speed / sailState);
            }

        }

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
        //Destroy(gameObject);


    }




}
