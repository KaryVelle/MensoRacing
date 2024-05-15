using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour
{
    [SerializeField] private CheckChecker checker;
   [SerializeField] private CharacterController player;

   public void OnTriggerEnter(Collider other)
   {
       if (other.CompareTag("Player"))
       {
           player.Move(checker.currentPoint.position);
       }
   }
}
