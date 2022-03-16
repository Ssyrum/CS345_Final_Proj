using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackPoint : MonoBehaviour
{
    public int attDmg;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("doing damage");
            collision.GetComponent<PlayerHealth>().TakeDamage(attDmg);
            
        }
    }
}
