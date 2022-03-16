using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Debug.Log("doing damage");
            collision.GetComponent<EnemyHealth>().TakeDamage(1);
            
        }
    }
}
