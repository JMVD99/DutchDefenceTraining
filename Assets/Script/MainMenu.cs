﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public bool isStart;
    public bool isQuit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnMouseUp() {
        if (isQuit) {
            Application.Quit ();
        } if(isStart) {
            Application.LoadLevel (0);
        }
    }
}
