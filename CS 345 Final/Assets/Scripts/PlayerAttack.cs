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
        if (Input.GetKey(KeyCode.G))
        {
            // animator.SetBool("attack", true);
            Attack();
            timeBetweenHits = .25f;

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
        
        // foreach (Collider2D enemy in hitEnemies)
        // {
        //     Debug.Log("enemy");
        //     enemy.GetComponent<EnemyHealth>().TakeDamage(attackDmg);
        // }
    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }

}
