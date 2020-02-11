using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveDataHelper : MonoBehaviour
{
    public SaveData data = new SaveData();

    public string Path => Application.persistentDataPath + "/data.json";

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Save();
        }

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            Load();
        }
    }

    void Save()
    {
        Debug.Log("Saving...");
        data.Save();
    }

    void Load()
    {
        Debug.Log("Loading...");
        data = SaveData.Load();
    }

#if DEVELOPMENT_BUILD || UNITY_EDITOR
    private void OnGUI()
    {
        GUILayout.Box($"Name: {data.name}\nPlay Time:{data.playtime}");
    }
#endif
}
