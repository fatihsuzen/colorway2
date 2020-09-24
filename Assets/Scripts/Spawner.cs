using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    public List<GameObject> GameObjects = new List<GameObject>();

    int randomLeft, randomMid, randomRight, randomcolor;
    float nextSpawn = 0f;
    public static float time =3.2f;
    public static int difficulty=3;
    void Start()
    {
        randomLeft = Random.Range(0, GameObjects.Count);
        randomMid = Random.Range(0, GameObjects.Count);
        randomRight = Random.Range(0, GameObjects.Count);
        randomcolor = Random.Range(0, GameObjects.Count);
      
    }
    void Update()
    {
       
        difficulty = Difficulty.difficulty1;
        if (Time.time > nextSpawn)
        {
            randomLeft = Random.Range(0, GameObjects.Count);
            randomMid = Random.Range(0, GameObjects.Count);
            randomRight = Random.Range(0, GameObjects.Count);
            randomcolor = Random.Range(0, GameObjects.Count);
           
            int fark = 0;

            for (int i = 0; i<difficulty;i++)
            {
                fark += 2;
                Instantiate(GameObjects[0 + randomLeft], new Vector3(2, 0.5f, 120f+ fark), Quaternion.identity);
                Instantiate(GameObjects[0 + randomMid], new Vector3(0, 0.5f, 120f+ fark), Quaternion.identity);
                Instantiate(GameObjects[0 + randomRight], new Vector3(-2, 0.5f, 120f+ fark), Quaternion.identity);
                
            }
            
            WhichColor(randomcolor, randomLeft, randomMid, randomRight);

            nextSpawn = Time.time + time;

           
            }
       
        
    }
    void WhichColor(int randomcolor, int randomLeft, int randomMid, int randomRight)
    {
        if (randomcolor == 0)
        {
            if (randomLeft == 0)
            {
                Camera.main.backgroundColor = Color.Lerp(Color.white, Color.red, 1f);
                Score.whichColor = "red";
            }
            if (randomLeft == 1)
            {
                Score.whichColor = "blue";
                Camera.main.backgroundColor = Color.Lerp(Color.white, Color.blue, 1f);
            }
            if (randomLeft == 2)
            {
                Score.whichColor = "green";
                Camera.main.backgroundColor = Color.Lerp(Color.white, Color.green, 1f);
            }


        }
        if (randomcolor == 1)
        {
            if (randomMid == 0)
            {
                Score.whichColor = "red";
                Camera.main.backgroundColor = Color.Lerp(Color.white, Color.red, 1f);
            }
            if (randomMid == 1)
            {
                Score.whichColor = "blue";
                Camera.main.backgroundColor = Color.Lerp(Color.white, Color.blue, 1f);
            }
            if (randomMid == 2)
            {
                Score.whichColor = "green";
                Camera.main.backgroundColor = Color.Lerp(Color.white, Color.green, 1f);
            }
        }
        if (randomcolor == 2)
        {
            if (randomRight == 0)
            {
                Score.whichColor = "red";
                Camera.main.backgroundColor = Color.Lerp(Color.white, Color.red, 1f);
            }
            if (randomRight == 1)
            {
                Score.whichColor = "blue";
                Camera.main.backgroundColor = Color.Lerp(Color.white, Color.blue, 1f);
            }
            if (randomRight == 2)
            {
                Score.whichColor = "green";
                Camera.main.backgroundColor = Color.Lerp(Color.white, Color.green, 1f);
            }

        }
    }
}
