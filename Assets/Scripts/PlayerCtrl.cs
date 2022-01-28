using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public float speed = 5f;

    void Start()
    {

    }

    void Update()
    {
        float mx = Input.GetAxisRaw("Horizontal");
        float my = Input.GetAxisRaw("Vertical");

        Vector2 pos = transform.position;
        pos.x += mx * speed * Time.deltaTime;
        pos.y += my * speed * Time.deltaTime;
        transform.position = pos;

    }
}
