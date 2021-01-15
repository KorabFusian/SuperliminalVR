using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public bool Plate1Pressed;
    public bool Plate2Pressed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( Plate1Pressed && Plate2Pressed )
        {
            gameObject.transform.position = new Vector3(31.43f, 2, 34.847f);
        }
    }
}
