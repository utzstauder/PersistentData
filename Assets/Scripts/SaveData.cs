using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveData : GenericJsonClass<SaveData, UnityFileStorage>
{
    public static string SaveDataPath => Application.persistentDataPath + "/data." + Extension;

    public string name;
    public float playtime;

    public SaveData()
    {
        name = "Player";
        playtime = 0;
    }

    public void Save()
    {
        Save(SaveDataPath);
    }

    public static SaveData Load()
    {
        return Load(SaveDataPath);
    }

}
