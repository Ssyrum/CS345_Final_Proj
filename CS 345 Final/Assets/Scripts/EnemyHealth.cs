using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float maxHealth = 10f;
    public static float currentHealth;
    public GameObject enemy;

    private void Start()
    {
        currentHealth = 10f;
    }
    public void TakeDamage(int amount)
    {
        Debug.Log(currentHealth);
        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("dead");
    }
}
