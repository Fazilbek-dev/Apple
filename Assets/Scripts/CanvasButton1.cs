using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasButton1 : MonoBehaviour
{
    Rigidbody2D rb;
    Basket b;

    public GameObject mainMenu;
    public GameObject RecomMenu;

    public void Lose()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Win()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void main()
    {
        Time.timeScale = 0f;        //  Останавливает игру
        enabled = false;
        mainMenu.SetActive(true);
    }
    public void mainoff()
    {
        Time.timeScale = 1f;
        enabled = true;
        mainMenu.SetActive(false);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    public void playmenu()
    {
        SceneManager.LoadScene("level1");
        Time.timeScale = 1f;
        enabled = true;
    }

    public void Level1()
    {
        SceneManager.LoadScene("level1");
        Time.timeScale = 1f;
        enabled = true;
    }

    public void Level2()
    {
        SceneManager.LoadScene("level2");
        Time.timeScale = 1f;
        enabled = true;
    }
    public void Levels()
    {
        SceneManager.LoadScene("Levels");
    }

    public void RecomClose()
    {
        RecomMenu.SetActive(false);
    }

    public void RecomOpen()
    {
        RecomMenu.SetActive(true);
    }
}
