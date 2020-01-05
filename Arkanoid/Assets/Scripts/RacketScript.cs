using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketScript : MonoBehaviour
{
    public float speed = 3;

    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");

        GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;
    }
}
