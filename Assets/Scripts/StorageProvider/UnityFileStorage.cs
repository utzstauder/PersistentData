using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class UnityFileStorage : IFileStorage
{
    public string Type => "UnityFileStorage";

    public string Retrieve(string filePath)
    {
        return File.ReadAllText(filePath);
    }

    public void Store(string filePath, string data)
    {
        File.WriteAllText(filePath, data);
    }
}
