using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int totalPoint;
    public int stagePoint;
    public int stageIndex;
    public int Health;


    public void NextStage()
    {
        stageIndex++;
        totalPoint+= stagePoint;
        stagePoint = 0;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Health Down
            Health--;
            //Player Reposition
            collision.attachedRigidbody.velocity = Vector2.zero;
            collision.transform.position = new Vector3(-0.1f, 7, -1);
        }
    }
}
