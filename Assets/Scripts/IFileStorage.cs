using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IFileStorage
{
    string Type { get; }
    void Store(string filePath, string data);
    string Retrieve(string filePath);
}
