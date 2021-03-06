using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    [SerializeField] Slider slider;

    public void SetMaxHealth(int HP)
    {
        slider.maxValue = HP;
        slider.value = HP;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }

}
