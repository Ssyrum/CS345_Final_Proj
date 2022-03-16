using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillEnemyHealth : MonoBehaviour
{
    Vector3 localScale;

    void Start()
    {
        localScale = transform.localScale;
    }

    void Update()
    {
        localScale.x = EnemyHealth.currentHealth;
        transform.localScale = localScale;
    }
    // public EnemyHealth enemyHealth;
    // public Image fillImage;
    // private Slider slider;

    // private void Awake()
    // {
    //     slider = GetComponent<Slider>();
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     if (slider.value <= slider.minValue)
    //     {
    //         fillImage.enabled = false;
    //     }

    //     if (slider.value > slider.minValue && !fillImage.enabled)
    //     {
    //         fillImage.enabled = true;
    //     }

    //     float fillValue = enemyHealth.currentHealth / enemyHealth.maxHealth;

    //     if ((fillValue <= slider.maxValue / 2) && (fillValue > slider.maxValue / 5))
    //     {
    //         fillImage.color = Color.yellow;
    //     }

    //     if (fillValue <= slider.maxValue / 5)
    //     {
    //         fillImage.color = Color.red;
    //     }

    //     else if (fillValue > slider.maxValue / 2)
    //     {
    //         fillImage.color = Color.green;
    //     }
    //     slider.value = fillValue;
    // }
}
