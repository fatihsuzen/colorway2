using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour
{
    public static int lvlpoint = 30;
    public static int difficulty1=3;

    // Update is called once per frame
    void Update()
    {
       
        if(Score.scoreint > lvlpoint && Score.scoreint < 400)
        {
          difficulty1 += 1;
          MaterialMovement.speed += 0.15f;
          lvlpoint += 30;
          Spawner.time -= 0.03f;
            
        }

    }
}
