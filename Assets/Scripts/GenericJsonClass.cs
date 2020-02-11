using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public abstract class GenericJsonClass<T> where T : class
{
    public static readonly string Extension = "json";

    public void Save(string filePath)
    {
        string dataAsJson = JsonUtility.ToJson(this);
        File.WriteAllText(filePath, dataAsJson);
    }

    public static T Load(string filePath)
    {
        string dataAsJson = File.ReadAllText(filePath);

        T data = JsonUtility.FromJson<T>(dataAsJson);

        return data;
    }
}
