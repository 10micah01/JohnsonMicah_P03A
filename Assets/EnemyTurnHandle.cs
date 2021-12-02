using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurnHandle : MonoBehaviour
{
    public bool FinishedTurn;
    public int AttackAmounts;
    [SerializeField] AudioClip atkSound = null;

    public void Start()
    {
        FinishedTurn = false;
        Audio.PlayClip2D(atkSound, .3f);
        int atkNumb = Random.Range(0, AttackAmounts);
        GetComponent<Animator>().SetInteger("AtkDex", atkNumb);
    }

    public void AtkDone()
    {
        FinishedTurn = true;
    }
}
