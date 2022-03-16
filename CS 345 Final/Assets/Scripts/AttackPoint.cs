using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPoint : MonoBehaviour
{
    public int attDmgFists;
    public int attDmgRuler;
    public int attDmgBall;
    public int attDmgJumpRope;
    public int attDmgMarker;
    public Animator animator;

    void Awake()
    {
        animator = GetComponentInParent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            if (animator.GetBool("fists"))
            {
                collision.GetComponent<EnemyHealth>().TakeDamage(attDmgFists);
            }
            if (animator.GetBool("ruler"))
            {
                collision.GetComponent<EnemyHealth>().TakeDamage(attDmgRuler);
            }
            if (animator.GetBool("ball"))
            {
                collision.GetComponent<EnemyHealth>().TakeDamage(attDmgBall);
            }
            if (animator.GetBool("jumprope"))
            {
                collision.GetComponent<EnemyHealth>().TakeDamage(attDmgJumpRope);
            }
            if (animator.GetBool("marker"))
            {
                collision.GetComponent<EnemyHealth>().TakeDamage(attDmgMarker);
            }

            // Debug.Log("doing damage");
            // collision.GetComponent<EnemyHealth>().TakeDamage(attDmg);
            
        }
    }
}
