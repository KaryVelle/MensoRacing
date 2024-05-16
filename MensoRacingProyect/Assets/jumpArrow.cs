using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpArrow : MonoBehaviour
{
    
    [SerializeField] public float speed = 5;
    [SerializeField] public float height = 10;
    private Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
    }
    void Update()
    {
        float newY = Mathf.Sin(Time.time * speed);
        transform.position = new Vector3(startPos.x, newY * height, startPos.z);
    }
}
