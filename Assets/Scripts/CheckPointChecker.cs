using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointChecker : MonoBehaviour
{
    public CarController theCar;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Checkpoint")
        {
            //Debug.Log("Hit cp" + other.GetComponent<CheckPoint>().cpNumber);

            theCar.CheckpointHit(other.GetComponent<CheckPoint>().cpNumber);
        }
    }
}
