using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public abstract class GenericJsonClass<T, S>
    where T : class
    where S : IFileStorage, new()
{
    public static readonly string Extension = "json";

    private static IFileStorage storage;
    public static IFileStorage Storage
    {
        get
        {
            if (storage == null)
            {
                storage = new S();
            }
            return storage;
        }
    }

    public void Save(string filePath)
    {
        string dataAsJson = JsonUtility.ToJson(this);

        Storage.Store(filePath, dataAsJson);
    }

    public static T Load(string filePath)
    {
        string dataAsJson = Storage.Retrieve(filePath);

        T data = JsonUtility.FromJson<T>(dataAsJson);

        return data;
    }
}
