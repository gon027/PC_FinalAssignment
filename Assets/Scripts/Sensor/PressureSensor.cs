﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class PressureSensor : MonoBehaviour
{
    SerialPort stream = new SerialPort("/dev/cu.usbmodem14202", 57600);
    private bool isPressedA, isPressedB, isPressedC;   
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
