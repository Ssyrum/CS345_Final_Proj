using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    [SerializeField]
    private Transform centerBackground;

    void Update()
    {
        if (transform.position.x >= centerBackground.position.x + 19.2f)
        {
            centerBackground.position = new Vector2(centerBackground.position.x + 19.2f, centerBackground.position.y);
        }
        else if (transform.position.x <= centerBackground.position.x - 19.2f)
        {
            centerBackground.position = new Vector2(centerBackground.position.x - 19.2f, centerBackground.position.y);
        }
        
    }
}
