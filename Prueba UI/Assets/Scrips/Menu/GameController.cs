using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public void OnLoadGame()
    {
        SceneManager.LoadScene(1);
    }

    public void OnLoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void OnExit()
    {
        Application.Quit();
    }

}
