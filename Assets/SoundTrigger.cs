using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{

    AudioSource clip;
    public Collider other;
    
    // Start is called before the first frame update
    void Start()
    {
        clip = GetComponent<AudioSource>();
    }

    // Update is called once per frame

    public void OnTriggerEnter(Collider other)
    {
        //AudioSource.PlayClipAtPoint(clip, transform.position);
        clip.Play();
        Debug.Log("DAAA");

    }

    public void OnTriggerExit(Collider other)
    {
        clip.Stop();
        Debug.Log("NUUU");
    }

    void Update()
    {
        
    }
}
