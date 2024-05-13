using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour
{
   [SerializeField] private Collider col;

   public void OnTriggerEnter(Collider other)
   {
       if (other.CompareTag("Player"))
       {
           SceneManager.LoadScene("GameScene");
       }
   }
}
