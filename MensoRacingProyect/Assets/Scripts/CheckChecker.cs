using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckChecker : CheckpointCheckerClass
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entracualqueir trigger");
        if (other.transform.tag == "Checkpoint")
        {
            Debug.Log("entro");
            currentPointLoad = other.GetComponent<Transform>();
            checkpoints.Add(currentPointLoad);
        }
    }
}
