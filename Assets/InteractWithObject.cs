using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithObject : MonoBehaviour
{
    [SerializeField]
    GameObject OtherObject;

    void OnTriggerEnter(Collider other)
    {
        OtherObject = other.gameObject;
    }

    void OnTriggerExit()
    {
        OtherObject = null;
    }
}
