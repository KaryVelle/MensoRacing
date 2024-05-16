using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

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
    
    [SerializeField] private CheckChecker checker;
    [SerializeField] private GameObject playerToMove;

    [SerializeField] private CinemachineVirtualCamera cinemachineVc;
    [SerializeField] private GameObject playerToFollow;

    [SerializeField] private Image animImg;

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
        cinemachineVc.Follow = null;
        StartCoroutine(Respawn());
    }

    private IEnumerator Respawn()
    {
        float fillSpeed = 2.0f / 1.0f;

        yield return new WaitForSeconds(1);
    
        // Llena la pantalla
        while (animImg.fillAmount < 1)
        {
            animImg.fillAmount += fillSpeed * Time.deltaTime; 
            yield return null; 
        }
    
        yield return new WaitForSeconds(0.3f);
    
        // Mueve al jugador instantáneamente al punto de destino
        player.enabled = false;
        playerToMove.transform.position = checker.currentPointLoad.position;
        cinemachineVc.Follow = playerToFollow.transform; 

        // Restablece la pantalla gradualmente
        while (animImg.fillAmount > 0)
        {
            animImg.fillAmount -= fillSpeed * Time.deltaTime; 
            yield return null; 
        }

        // Habilita el control del jugador y restablece la cámara para seguir al jugador
        player.enabled = true;
        
    }

}

