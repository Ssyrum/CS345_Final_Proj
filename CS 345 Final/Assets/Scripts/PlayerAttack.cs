using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    private float timeToAttack;
    public float startTimeToAttack;

    public Transform attackPos;
    public LayerMask whatIsEnemies;
    public float attackRange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeToAttack <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                //from tutorial for melee weapons, needs to be adjusted for different weapons
                /*Collider2D[0] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<Enemy>().TakeDamage(damage);
                };*/
            }
            timeToAttack = startTimeToAttack;
        }
        else
        {
            timeToAttack -= Time.deltaTime;
        }
    }
}
