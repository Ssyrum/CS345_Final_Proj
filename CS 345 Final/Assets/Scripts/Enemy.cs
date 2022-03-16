using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed;
    public float chaseDistance;
    public float stopDistance;
    public GameObject target;

    private float targetDistance;
    public float attackDistance;

    public Animator animator;
    EnemyAttack enemyattack;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        targetDistance = Vector2.Distance(transform.position, target.transform.position);
        if (targetDistance < chaseDistance && targetDistance > stopDistance)
        {
            ChasePlayer();
        }
        else
        {
            StopChasePlayer();
        }
    }

    private void StopChasePlayer()
    {
        /* Do nothing */
    }

    private void ChasePlayer()
    {
        if (targetDistance < attackDistance)
        {
            GetComponent<EnemyAttack>().Attack();
        }

        Vector2 newVel = Vector2.zero;
        if (transform.position.x < target.transform.position.x)
        {
            //transform.GetChild(1).GetComponent<SpriteRenderer>().flipX = false;
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        else
        {
            //transform.GetChild(1).GetComponent<SpriteRenderer>().flipX = true;
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        newVel.x = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("speed", newVel.sqrMagnitude);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "AttackPoint")
        {
            animator.SetTrigger("hit");
        }
    }
}
