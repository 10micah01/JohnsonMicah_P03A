using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int HP;
    public int MaxHp;

    public void TakeDamage(int Dmg)
    {
        HP -= Dmg;

        if (HP <= 0)
        {
            Death();
        }
    }

    void Death()
    {
        Debug.Log("Player has Died");
    }
}

