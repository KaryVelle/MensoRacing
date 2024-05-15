using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckChecker : CheckpointCheckerClass
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Checkpoint"))
        {
            Debug.Log("Check");
            currentPoint = other.GetComponent<Transform>();
            checkpoints.Add(currentPoint);
        }
    }
}
