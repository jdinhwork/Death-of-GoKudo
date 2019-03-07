using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Animator animator;

    public float fireRate = 0;
    public float Damage = 10;
    public LayerMask notToHit;

    float timeToFire = 0;
    public Transform firePoint;
    public GameObject kunaiPrefab;

    // Start is called before the first frame update
    void Awake ()
    {
        firePoint = transform.FindChild ("FirePoint");
        if (firePoint == null)
        {
            Debug.LogError("No FirePoint?");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (fireRate == 0)
        {
            if (Input.GetButtonDown ("Fire1"))
            {
                Shoot();
                animator.SetBool("IsThrowing", true);
            }
            else
            {
                animator.SetBool("IsThrowing", false);
            }
        }
        else
        {
            if (Input.GetButtonDown ("Fire1") && Time.time > timeToFire)
            {
                timeToFire = Time.time + 1 / fireRate;
                Shoot();
            }
        }
    }
    
    void Shoot ()
    {
        Instantiate(kunaiPrefab, firePoint.position, firePoint.rotation);
    }
}
