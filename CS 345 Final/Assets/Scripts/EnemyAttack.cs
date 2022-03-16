using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public Animator animator;

    public Transform attackPoint;
    public float attackRange = 0.5f;
    public int attackDmg = 2;

    public LayerMask enemyLayers;

    public GameObject gameObject;

    private float timeBetweenHits = .5f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
        timeBetweenHits = .5f;
        // timeBetweenHits -= Time.deltaTime;

        if (timeBetweenHits <= 0f)
        {
            animator.SetBool("attack", false);
            timeBetweenHits = .25f;
        }
    }

    public void Attack()
    {
        animator.SetBool("attack", true);

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        
        foreach (Collider2D enemy in hitEnemies)
        {
            Debug.Log("player");
            enemy.GetComponent<PlayerHealth>().TakeDamage(attackDmg);
        }
    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
