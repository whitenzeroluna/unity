using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; // 回転速度
    
    void Start()
    {
        //　フレームルートを６０に固定する
        Application.targetFrameRate  = 60;
    }

    void Update()
    {
        //　マウスが推されたら回転速度を設定する
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 60;
        }
    
        // 回転速度ぶん、ルーレットを回転させる
     transform.Rotate(0, 0, this.rotSpeed);
     
     // ルーレットｗｐ減速させる(追加)
     this.rotSpeed *= 0.96f;
     }
}
