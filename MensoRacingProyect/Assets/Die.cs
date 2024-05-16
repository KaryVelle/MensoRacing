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
   [SerializeField] private float moveSpeed = 500;

   public void OnTriggerEnter(Collider other)
   {
       if (other.CompareTag("Player"))
       {
           MoveTowardsTarget(checker.currentPointLoad.position);
       }
   }

   void MoveTowardsTarget(Vector3 target)
   {
       Debug.Log("entro");
       cc = player.GetComponent<CharacterController>();
       var offset = target - transform.position;
       offset = offset.normalized * moveSpeed;
       cc.Move(offset * Time.deltaTime);

   }
}
