using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsStorage : IFileStorage
{
    public string Type => "PlayerPrefsStorage";

    public string Retrieve(string filePath)
    {
        return PlayerPrefs.GetString(filePath);
    }

    public void Store(string filePath, string data)
    {
        PlayerPrefs.SetString(filePath, data);
    }
}
