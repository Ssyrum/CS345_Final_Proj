using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    public Animator animator;

    public Transform attackPoint;
    public float attackRange = 0.5f;
    public int attackDmg = 2;

    public LayerMask enemyLayers;

    public GameObject gameObject;

    private float timeBetweenHits = .25f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            // animator.SetBool("attack", true);
            Attack();
            timeBetweenHits = .25f;
            
                //from tutorial for melee weapons, needs to be adjusted for different weapons
                /*Collider2D[0] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<Enemy>().TakeDamage(damage);
                };*/
        }
        timeBetweenHits -= Time.deltaTime;

        if (timeBetweenHits <= 0f)
        {
            animator.SetBool("attack", false);
            timeBetweenHits = .25f;
        }
    }

    void Attack()
    {
        animator.SetBool("attack", true);

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        
        foreach (Collider2D enemy in hitEnemies)
        {
            Debug.Log("enemy");
            enemy.GetComponent<EnemyHealth>().TakeDamage(attackDmg);
        }
    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }

    // void OnTriggerEnter2D(Collider2D collider)
    // {
    //     if (collider.gameObject.tag == "Enemy" && animator.GetBool("attack"))
    //     {
    //         EnemyHealth.currentHealth -= 2f;
    //     }
    // }
}
