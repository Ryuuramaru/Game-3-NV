﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xhair : MonoBehaviour
{
    // Start is called before the first frame update

    public Texture2D crosshairImage;

    void Start()
    {
        
    }

    void OnGUI()
    {
        float xMin = (Screen.width / 2) - (crosshairImage.width / 2);
        float yMin = (Screen.height / 2) - (crosshairImage.height / 2);
        GUI.DrawTexture(new Rect(xMin, yMin, crosshairImage.width, crosshairImage.height), crosshairImage);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
