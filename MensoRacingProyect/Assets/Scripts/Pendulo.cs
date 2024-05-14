using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pendulo : MonoBehaviour
{
    public float move = 1.5f; 
    public float speed = 2.0f;
    public float direction = 1;
    private Quaternion startPos;
    public  Quaternion rot;

    [SerializeField] private float xForce;
    [SerializeField] private float yForce;
    [SerializeField] private float zForce;
   
    
    [SerializeField] private Collider colCylinder;
    [SerializeField] private CharacterController player;

    [SerializeField] private AudioSource polloScream;

    void Start()
    {
        startPos = transform.rotation;
        colCylinder.GetComponent<Collider>();
        player.GetComponent<CharacterController>();
    }

    void Update()
    {
        rot = startPos;
        rot.x += direction * (move * Mathf.Sin(Time.time * speed));
        transform.rotation = rot;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            polloScream.Play();
            AddForce();
        }
    }

    private void AddForce()
    {
        player.Move(new Vector3(rot.x + xForce, rot.y +yForce, 0 + zForce));
        Debug.Log("Force");
    }
}

