using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour
{
    [SerializeField] private CheckChecker checker;
   [SerializeField] private CharacterController cc;
   [SerializeField] private GameObject player;
   [SerializeField] private GameObject playerToMove;
   [SerializeField] private float moveSpeed = 500;

   public void OnTriggerEnter(Collider other)
   {
       if (other.CompareTag("Player"))
       {
           
       }
   }

  
}
