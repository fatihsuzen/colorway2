using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl2 : MonoBehaviour
{

    // Update is called once per frame

    public void FuncScene(string SceneName)
    {
        if (SceneName == "Exit")
        {
            Application.Quit();
        }
        else
        {
           SceneManager.LoadScene(SceneName);
        }
        
    }

}
