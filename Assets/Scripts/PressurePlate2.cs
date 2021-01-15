using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate2 : MonoBehaviour
{
    [SerializeField]
    GameObject door;

    void onTriggerEnter(Collider col)
    {
        door.GetComponent<OpenDoor>().Plate2Pressed = true;
    }
}
