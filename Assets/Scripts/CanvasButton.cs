using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasButton : MonoBehaviour
{
    Rigidbody2D rb;
    Basket b;

    public GameObject mainMenu;

    public void Left()
    {
        rb.velocity = Vector2.left * b.speed;
    }
    public void Right()
    {
        rb.velocity = Vector2.right * b.speed;
    }

    public void Lose()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Win()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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
}
