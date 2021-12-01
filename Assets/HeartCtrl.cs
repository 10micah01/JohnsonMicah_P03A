using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartCtrl : MonoBehaviour
{
    private Vector3 Startingpos = Vector3.zero;

    public float speed;
    public float Sensitivity;
    private Vector2 MovePos;

    public float MaxX = 1.9f;
    public float MaxY = 1.9f;
    public float MinX = -1.9f;
    public float MinY = -1.9f;

    void Start()
    {
        SetHeart();
    }

    public void SetHeart()
    {
        transform.position = Startingpos;
        MovePos = Startingpos;
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal") * Sensitivity;
        float vertical = Input.GetAxis("Vertical") * Sensitivity;

        MovePos.x += horizontal;
        MovePos.y += vertical;

        MovePos.x = Mathf.Clamp(MovePos.x, MinX, MaxX);
        MovePos.y = Mathf.Clamp(MovePos.y, MinY, MaxY);

        transform.position = Vector2.Lerp(transform.position, MovePos, speed * Time.deltaTime);
    }
}
