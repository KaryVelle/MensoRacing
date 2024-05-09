using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulo : MonoBehaviour
{
    public float move = 1.5f; 
    public float speed = 2.0f;
    public float direction = 1;

    private Quaternion startPos;

    void Start()
    {
        startPos = transform.rotation;
    }

    void Update()
    {
        Quaternion rot = startPos;
        rot.x += direction * (move * Mathf.Sin(Time.time * speed));
        transform.rotation = rot;
    }
}

