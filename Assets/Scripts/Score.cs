using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static bool scorePlus=true;
    public static int scoreint,health=20;
    public static string whichColor;
   
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<AudioSource>().Play();

        if (whichColor == collision.collider.tag)
        {  
            scoreint++;

            scoreText.text = scoreint.ToString();
        }
        else
        {
            Healthbar.health-=10; 
            
            scoreText.text = scoreint.ToString();
        }
    }
}
