using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ForcePush : MonoBehaviour
{
    public float force;
    public float range;
    public Transform childTransform;
    //public Rigidbody rb;

    RaycastHit hit;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Physics.Raycast(transform.position, transform.forward, out hit, range * 0.5f))
        {
            if (hit.collider.CompareTag("Pushable"))
            {
                hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * force, ForceMode.Impulse);
                hit.collider.gameObject.GetComponent<Rigidbody>().AddTorque(transform.right * 50f);

            }
        }

        if (Input.GetMouseButton(1) && Physics.Raycast(transform.position, transform.forward, out hit, range * 1.5f))
        {
            if (hit.collider.CompareTag("Pushable") && hit.distance >= 2.5f)
            {
                /*if (hit.distance <= 5f) hit.collider.gameObject.GetComponent<Rigidbody>().position = Vector3.Lerp(childTransform.transform.position, hit.collider.gameObject.GetComponent<Rigidbody>().position, 0.1f);
                else*/ hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * -1 * force * 0.2f, ForceMode.Force);
            }
                
        }

        if (Input.GetButtonDown("Push") && Physics.Raycast(transform.position, transform.forward, out hit, range * 0.5f))
        {
            if (hit.collider.CompareTag("Pushable"))
            {
                hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * force * 0.5f, ForceMode.Impulse);
                hit.collider.gameObject.GetComponent<Rigidbody>().AddTorque(transform.right * 20f);
            }
        }
    }
}

