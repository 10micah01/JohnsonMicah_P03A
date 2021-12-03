using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPmeter : MonoBehaviour
{
    public Color ActiveCol;
    public Color PassiveCol;
    private Color Col;
    [SerializeField] AudioClip grazeSound = null;
    public HealthBar healthBar;
    private float ColLerp;

    private SpriteRenderer Sprt;
    public float TPAmt;
    void Start()
    {
        ColLerp = 0;
        TPAmt = 0;
        Sprt = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Col = Color.Lerp(PassiveCol, ActiveCol, ColLerp);
        Sprt.color = Col;

        if (ColLerp > 0)
        {
            ColLerp -= Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<EnemyAtkHazard>())
        {
            Audio.PlayClip2D(grazeSound, 1f);
            ColLerp = 1;

            if (TPAmt < 100)
            {
                
                TPAmt += 1f;
                healthBar.SetHealth(TPAmt);
            }
        }
    }
}
