using System;
using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

public class TrampolineClass : MonoBehaviour
{
    [SerializeField] public Collider colBounce;
    [SerializeField] public CharacterController player;
    [SerializeField] public ThirdPersonController charController;

    public void Start()
    {
        charController = player.GetComponent<ThirdPersonController>();
    }

   
  
    
}
