using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int HP;
    public int MaxHp;
    [SerializeField] AudioClip dmgSound = null;
    [SerializeField] private float invincibilityDurationSeconds;
    [SerializeField] private float invincibilityDeltaTime;
    [SerializeField] private GameObject model;
    private bool isInvincible = false;

    public void TakeDamage(int Dmg)
    {
        if (isInvincible) return;

        Audio.PlayClip2D(dmgSound, 1f);
        HP -= Dmg;
        Debug.Log("Damage");
        StartCoroutine(BecomeTemporarilyInvincible());
        if (HP <= 0)
        {
            Death();
        }
    }

    void Death()
    {
        Debug.Log("Player has Died");
    }

    private IEnumerator BecomeTemporarilyInvincible()
    {
        Debug.Log("Player turned invincible!");
        isInvincible = true;

        for (float i = 0; i < invincibilityDurationSeconds; i += invincibilityDeltaTime)
        {
            if (model.transform.localScale == Vector3.one)
            {
                ScaleModelTo(Vector3.zero);
            }
            else
            {
                ScaleModelTo(Vector3.one);
            }
            yield return new WaitForSeconds(invincibilityDeltaTime);
        }

        Debug.Log("Player is no longer invincible!");
        ScaleModelTo(Vector3.one);
        isInvincible = false;
    }

    private void ScaleModelTo(Vector3 scale)
    {
        model.transform.localScale = scale;
    }
}
