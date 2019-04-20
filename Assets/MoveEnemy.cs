using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    Rigidbody2D Rb;
    Vector3 Groundcheck;
    public float speed;
    private bool IsMoving;

    // Start is called before the first frame update
    void Start()
    {
        IsMoving = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsMoving)
        {
            Move();
        }
       
    }

    void Move()
    {
        transform.Translate(Vector3.left * speed, Space.Self); 
    }

    public void Flip()
    {
        transform.Rotate(0, 180, 0);
    }

    public void SetIsMoving(bool b)
    {
        IsMoving = b;
    }

    public void Attack()
    {
        GetComponent<EnemyAttack>().Shoot();

    }


}
