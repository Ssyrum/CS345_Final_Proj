using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    // public bool isFollowing;
    // public float cameraSpeed;

    // Vector2 playerXPos;

    // GameObject playerTarget;
    [SerializeField]
    private Transform targetToFollow;

    void Awake()
    {
        // playerTarget = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(targetToFollow.position.x, transform.position.y);

        // playerXPos = new Vector2 (playerTarget.transform.position.x, 0.0f);

        // if (isFollowing == true)
        // {
        //     transform.position = Vector2.Lerp(transform.position, playerXPos, cameraSpeed);
        // }
    }
}
