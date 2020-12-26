using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform TheDestination;

    private float originalFrustumHeight;
    private Vector3 originalScale;

    private Camera PlayerCam;

    void OnMouseDown()
    {
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().freezeRotation = true;
        gameObject.layer = 2;
    }

    void OnMouseUp()
    {
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().freezeRotation = false;
        GetComponent<BoxCollider>().enabled = true;
        gameObject.layer = 8;
    }

    private void Start()
    {
        PlayerCam = Camera.main;
        originalFrustumHeight = 2.0f * Vector3.Distance(PlayerCam.gameObject.transform.position, this.transform.position) * Mathf.Tan(PlayerCam.fieldOfView * 0.5f * Mathf.Deg2Rad);
        originalScale = transform.localScale;
    }

    private void Update()
    {
        float newFrustumHeight = 2.0f * Vector3.Distance(PlayerCam.gameObject.transform.position, this.transform.position) * Mathf.Tan(PlayerCam.fieldOfView * 0.5f * Mathf.Deg2Rad);
        float scaleFactor = newFrustumHeight / originalFrustumHeight;
        gameObject.transform.localScale = originalScale * scaleFactor;
    }

}
