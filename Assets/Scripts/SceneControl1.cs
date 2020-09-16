using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl1 : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(Healthbar.health<=5)
        {
            Spawner.time = 3.2f;
            Difficulty.lvlpoint = 30;
            Difficulty.difficulty1 = 3;
            Score.scoreint = 0;
            Healthbar.health = 99;
            SceneManager.LoadScene("GameOver");
        
        }
    }
    public void NewGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
