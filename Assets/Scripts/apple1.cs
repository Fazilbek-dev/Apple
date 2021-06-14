using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using UnityEngine;

public class apple1 : MonoBehaviour
{
    public GameObject applePrefab;
    public GameObject WarningApple;
    public GameObject LievPrefab;
    public List<string> Pos = new List<string>();

    public bool CanGo = true;

    IEnumerable<int> i = Enumerable.Range(1, 10);


    //IEnumerable<int> posRandom = Enumerable.Range(0, 4);

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DropApple", 1f);
        Invoke("DropLiev", 6f);
        Invoke("DropWarningApple", 4f);
    }

    void DropApple()
    {
        GameObject Apple = Instantiate<GameObject>(applePrefab);
        Apple.transform.position = transform.position;

        Invoke("DropApple", 1f);
    }

    void DropLiev()
    {
        GameObject Liev = Instantiate<GameObject>(LievPrefab);
        Liev.transform.position = transform.position;

        Invoke("DropLiev", 6f);
    }

    void DropWarningApple()
    {
        GameObject warApple = Instantiate<GameObject>(WarningApple);
        warApple.transform.position = transform.position;

        Invoke("DropWarningApple", 4f);
    }
}
