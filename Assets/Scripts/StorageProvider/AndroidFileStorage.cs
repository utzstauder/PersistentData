using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidFileStorage : IFileStorage
{
    public string Type => "AndroidFileStorage";

    public string Retrieve(string filePath)
    {
        throw new System.NotImplementedException();
    }

    public void Store(string filePath, string data)
    {
        throw new System.NotImplementedException();
    }
}
