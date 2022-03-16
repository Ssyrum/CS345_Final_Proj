using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public bool PickupItem(GameObject obj)
    {
        switch(obj.tag)
        {
            case "Apple":
                GetComponent<PlayerHealth>().Heal(1);
                return true;

            case "Beaker":
                //do something
                return true;

            case "Dodgeball":
                //do something
                return true;

            case "Markers":
                //do something
                return true;

            case "Ruler":
                //do something
                return true;

            case "Whip":
                //do something
                return true;

            default:
                Debug.LogWarning($"WARNING: No handler implemented for tag {obj.tag}.");
                return false;
        }
    }
}
