using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//use this class name to ref object
public class projectile : MonoBehaviour
{

    public AudioClip hitSound1;
    private float currentTime;
    public float damage = 50f;

    public float GetDamage()
    {
        return damage;
    }

    public void Hit()
    {
        Destroy(gameObject);
    }

    void OnCollisionEnter(Collision collision)
    {
        projectile projectile = collision.gameObject.GetComponent<projectile>();
        if (collision.collider.tag == "anyShip")
        {
            if (projectile)
            {
                Destroy(gameObject);
                AudioSource.PlayClipAtPoint(hitSound1, transform.position);
            }
        }
    }

    void Start()
    {
        currentTime = 0;
    }

    void Update()
    {
        currentTime += Time.deltaTime;
       // print(currentTime);
        if (currentTime > 5) { Destroy(gameObject); }

    }


}

