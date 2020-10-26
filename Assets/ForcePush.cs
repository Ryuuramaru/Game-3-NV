using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForcePush : MonoBehaviour
{
    public float force = 1000.0f;
    public Rigidbody rb;

    RaycastHit hit;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Physics.Raycast(transform.position, transform.forward, out hit, 15f))
        {
            if (hit.collider.CompareTag("Pushable"))
                hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * force, ForceMode.Impulse);
        }
        
        if (Input.GetMouseButtonDown(1) && Physics.Raycast(transform.position, transform.forward, out hit, 15f))
        {
            if (hit.collider.CompareTag("Pushable"))
                hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * -1 * force * 0.4f, ForceMode.Impulse);
        }

        if (Input.GetButtonDown("Push") && Physics.Raycast(transform.position, transform.forward, out hit, 15f))
        {
            if (hit.collider.CompareTag("Pushable"))
                hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * force * 0.25f, ForceMode.Impulse); 
        }
    }
}