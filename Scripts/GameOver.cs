using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private MoneyDisplay showMoney;
    public static bool isGameOver = false;
    private void OnTriggerEnter(Collider collision)
    {
           if (collision.gameObject.tag == "Ground")
           {
               StartCoroutine("GameOverPanelCor");
           }
    }
    public IEnumerator GameOverPanelCor()
    {
        yield return new WaitForSeconds(0.1f);
        isGameOver = true;
        player.transform.Rotate(0, 0, 0, Space.World);
        PlayerControler.foward = true;
        player.SetActive(false);
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
        showMoney.Show_Money_Display();

    }

}