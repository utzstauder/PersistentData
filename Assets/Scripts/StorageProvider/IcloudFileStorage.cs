using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IcloudFileStorage : IFileStorage
{
    public string Type => "IcloudFileStorage";

    public string Retrieve(string filePath)
    {
        throw new System.NotImplementedException();
    }

    public void Store(string filePath, string data)
    {
        throw new System.NotImplementedException();
    }
}
