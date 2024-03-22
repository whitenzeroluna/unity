﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carcontroller : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        //スワイプの長さを求める
        if (Input.GetMouseButtonDown(0))
        {
            //マウスをクリックした座標
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            //マウスを話した座標
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - this.startPos.x;

            //スワイプの長さを初速度に変換する
            this.speed = swipeLength / 500.0f;
            
            //効果音再生
            GetComponent<AudioSource>().Play();
        }
        
        transform.Translate(this.speed, 0, 0); 
        this.speed *= 0.98f;
    }
}
