using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate1 : MonoBehaviour
{
    [SerializeField]
    GameObject door;

    void onTriggerEnter(Collider col)
    {
        print("yes");
        door.GetComponent<OpenDoor>().Plate1Pressed = true;
    }
}
