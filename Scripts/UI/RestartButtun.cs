using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButtun : MonoBehaviour
{
    public void RestartGame()
    {
        Time.timeScale = 1;
        GameOver.isGameOver = false;
        SceneManager.LoadScene(0);
    }
}
