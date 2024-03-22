﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate = 60;    
    }

    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0);
        if (transform.position.x < -9)
        {
            transform.Translate(21, 0, 0);
        }
    }
    
    public void RButtonDown()
    {
        transform.Translate(3, 0, 0);
        if (transform.position.x > 11)
        {
            transform.Translate(-21, 0, 0);
        }
    }

}
