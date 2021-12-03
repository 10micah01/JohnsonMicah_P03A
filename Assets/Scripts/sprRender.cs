using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprRender : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] newSprites;


    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    public void ChangeSprite(int index)
    {
        if (index > 0)
        { spriteRenderer.sprite = newSprites[index]; }
    }
}
