using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerManager manager = collision.GetComponent<PlayerManager>();
        if (manager)
        {
            bool pickedUp = manager.PickupItem(gameObject);
            if (pickedUp)
            {
                RemoveItem();
            }
        }
    }

    private void RemoveItem()
    {
        Destroy(gameObject);
    }
}
