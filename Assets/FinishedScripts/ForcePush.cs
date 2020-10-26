using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ForcePush : MonoBehaviour
{
    public float force;
    public float range;
    //public Rigidbody rb;

    RaycastHit hit;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Physics.Raycast(transform.position, transform.forward, out hit, range))
        {
            if (hit.collider.CompareTag("Pushable"))
                hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * force, ForceMode.Impulse);
        }

        if (Input.GetMouseButtonDown(1) && Physics.Raycast(transform.position, transform.forward, out hit, range))
        {
            if (hit.collider.CompareTag("Pushable"))
                hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * -1 * force * 0.6f, ForceMode.Impulse);
        }

        if (Input.GetButtonDown("Push") && Physics.Raycast(transform.position, transform.forward, out hit, range))
        {
            if (hit.collider.CompareTag("Pushable"))
                hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * force * 0.4f, ForceMode.Impulse);
        }
    }
}