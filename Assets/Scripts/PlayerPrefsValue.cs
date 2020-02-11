using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsValue : MonoBehaviour
{
    public string key = "myValue";

    private int num;
    public int Num
    {
        get
        {
            if (PlayerPrefs.HasKey(key))
            {
                num = PlayerPrefs.GetInt(key);
            }

            return num;
        }
    }

    public bool IsFullscreen
    {
        get
        {
            return PlayerPrefs.GetInt("IsFullscreen", 1) == 0 ? false : true;
        }
        set
        {
            PlayerPrefs.SetInt("IsFullscreen", (value ? 1 : 0));
        }
    }

    private void Awake()
    {
        int number = Random.Range(0, 100);
        Debug.LogFormat("{0}: {1}", key, number);
        PlayerPrefs.SetInt(key, number);
    }

    void Start()
    {
        int number = PlayerPrefs.GetInt(key, -1);
        Debug.LogFormat("{0}: {1}", key, number);
    }
}
