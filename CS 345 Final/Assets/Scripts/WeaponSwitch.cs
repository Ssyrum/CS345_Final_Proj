using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            animator.SetBool("fists", true);
            animator.SetBool("ruler", false);
            animator.SetBool("ball", false);
            animator.SetBool("jumprope", false);
            animator.SetBool("marker", false);

        }

        if (Input.GetKey(KeyCode.Alpha2))
        {
            animator.SetBool("fists", false);
            animator.SetBool("ruler", true);
            animator.SetBool("ball", false);
            animator.SetBool("jumprope", false);
            animator.SetBool("marker", false);

        }

        if (Input.GetKey(KeyCode.Alpha3))
        {
            animator.SetBool("fists", false);
            animator.SetBool("ruler", false);
            animator.SetBool("ball", true);
            animator.SetBool("jumprope", false);
            animator.SetBool("marker", false);

        }

        if (Input.GetKey(KeyCode.Alpha4))
        {
            animator.SetBool("fists", false);
            animator.SetBool("ruler", false);
            animator.SetBool("ball", false);
            animator.SetBool("jumprope", true);
            animator.SetBool("marker", false);

        }

        if (Input.GetKey(KeyCode.Alpha5))
        {
            animator.SetBool("fists", false);
            animator.SetBool("ruler", false);
            animator.SetBool("ball", false);
            animator.SetBool("jumprope", false);
            animator.SetBool("marker", true);

        }
    }
}
