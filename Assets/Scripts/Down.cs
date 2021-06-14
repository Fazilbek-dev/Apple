using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Down : MonoBehaviour
{
    public Basket basket;
    public Transform mainCamera;
    public Transform originalPos;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "apple")
        {
            basket.count--;
            Camera.main.gameObject.AddComponent<CameraShake>();
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "warApple")
        {
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "Liev")
        {
            Camera.main.gameObject.AddComponent<CameraShake>();
            Destroy(collision.gameObject);
        }
    }

    


}
