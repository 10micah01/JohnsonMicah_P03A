using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurnHandle : MonoBehaviour
{
    public bool FinishedTurn;
    public int AttackAmounts;

    public void Start()
    {
        FinishedTurn = false;

        int atkNumb = Random.Range(0, AttackAmounts);
        GetComponent<Animator>().SetInteger("AtkDex", atkNumb);
    }

    public void AtkDone()
    {
        FinishedTurn = true;
    }
}
