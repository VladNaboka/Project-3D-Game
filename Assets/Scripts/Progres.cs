using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progres : MonoBehaviour
{
    public int Coins;
    public int Wight;
    public int Height;

    public static Progres Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            transform.parent = null;
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

    }
}
