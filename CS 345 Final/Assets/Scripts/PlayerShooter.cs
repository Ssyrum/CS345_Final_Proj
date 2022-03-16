using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    public GameObject bullet;
    public float bulletSpeed;
    public float fireTime;
    public Animator animator;

    private Vector2 _lastVel = Vector2.up;
    private float _timeToFire;
    private Rigidbody2D _myRigidBody2D;

    void Start()
    {
        _myRigidBody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _timeToFire -= Time.deltaTime;
        if (_myRigidBody2D.velocity.magnitude > 0f)
        {
            _lastVel = _myRigidBody2D.velocity.normalized;
        }

        if (Input.GetKey(KeyCode.F) && _timeToFire <= 0f)
        {
            animator.SetBool("ball", true);
            _timeToFire = fireTime;
        }
    }

    public void FireBullet()
    {
        GameObject g0 = Instantiate(bullet, transform.position, Quaternion.Euler(_lastVel)) as GameObject;
        g0.GetComponent<Rigidbody2D>().velocity = _lastVel * bulletSpeed;
        g0.transform.localEulerAngles = animator.transform.localEulerAngles;


    }
}
