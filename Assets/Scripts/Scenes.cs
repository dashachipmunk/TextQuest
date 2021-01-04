using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void SceneMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void SceneGame()
    {
        SceneManager.LoadScene(1);
    }
    public void SceneWin()
    {
        SceneManager.LoadScene(2);
    }
    public void SceneGameOver()
    {
        SceneManager.LoadScene(3);
    }
}
