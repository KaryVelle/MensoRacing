using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class JumpArea : MonoBehaviour
{
    [SerializeField] private Collider jumpArea;
    [SerializeField] public ThirdPersonController charController;
    [SerializeField] public CharacterController player;
    
    void Start()
    {
        jumpArea.GetComponent<Collider>();
        charController = player.GetComponent<ThirdPersonController>();
    }

    private void OnTriggerExit(Collider other)
    {
        charController.JumpHeight = 1.2f;
    }
}
