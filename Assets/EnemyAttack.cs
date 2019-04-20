using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public Animator animator;

    public float fireRate = 0;
    public float Damage = 10;
    public LayerMask notToHit;

    float timeToFire = 0;
    public Transform firePoint;
    public GameObject kunaiPrefab;


    // Start is called before the first frame update
    void Awake()
    {
        firePoint = transform.Find("FirePoint");
        if (firePoint == null)
        {
            Debug.LogError("No FirePoint?");
        }
    }

    // Update is called once per frame
    void Update()
    {


    }

    public void Shoot()
    {
        if (fireRate == 0)
        {

        //    animator.SetBool("IsThrowing", true);
        }
       
        



        Instantiate(kunaiPrefab, firePoint.position, firePoint.rotation);
    }

    public void DisableAnimatorBool()
    {
       // animator.SetBool("IsThrowing", true);
    }

}