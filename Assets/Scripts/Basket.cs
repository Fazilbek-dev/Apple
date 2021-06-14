using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{
    [Header("statistics")]
    public float speed = 5f;
    public float timeWarApple = 2f;

    Rigidbody2D rb;

    public bool isWarning = false;

    public Text Score;

    public GameObject finish;
    public GameObject lose;

    public int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Score.text = "<size=40><color=#000>Score:</color></size> " + "<size=40><color=#000>" + count + "</color></size>";
    }

    public void Left()
    {
        rb.velocity = Vector2.left * speed;
    }
    public void Right()
    {
        rb.velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            rb.velocity = Vector2.right * speed;
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            rb.velocity = Vector2.left * speed;
        }
        else
            rb.velocity = rb.velocity;

        Score.text = "<size=40><color=#000>Score:</color></size> " + "<size=40><color=#000>" + count + "</color></size>";

        if (count >= 50)
            Win();

        if (count <= -10)
            Lose();


    }

    void Liev()
    {
        isWarning = false;
        count++;
        Invoke("Liev", 2f);
    }


    void WarningApple()
    {
        if (isWarning)
        {
            count--;
        }

        Invoke("WarningApple", timeWarApple);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "apple")
        {
            count++;                                       //   Добавляет очки за яблоки
            Destroy(collision.gameObject);                 //   Удаляет яблоко после начисление очков
        }
        if(collision.gameObject.tag == "warApple")
        {
            isWarning = true;
            Invoke("WarningApple", timeWarApple);
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "Liev")
        {
            isWarning = false;
            count++;
            Destroy(collision.gameObject);
        }
    }


    // Победа
    public void Win()
    {
        Time.timeScale = 0f;        //  Останавливает игру
        enabled = false;            //  Делает игрока не активным
        finish.SetActive(true);     //  Показывает кнопку победы
    }

    // Проигрыш
    public void Lose()
    {
        Time.timeScale = 0f;        //  Останавливает игру
        enabled = false;            //  Делает игрока не активным
        lose.SetActive(true);       //  Показывает кнопку проигрыша
    }
}
