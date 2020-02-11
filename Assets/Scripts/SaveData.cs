using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveData :
#if UNITY_SWITCH && !UNITY_EDITOR
    GenericJsonClass<SaveData, SwitchFileStorage>
#elif UNITY_ANDROID && !UNITY_EDITOR
    GenericJsonClass<SaveData, AndroidFileStorage>
#elif (UNITY_TVOS || UNITY_IOS) && !UNITY_EDITOR
    GenericJsonClass<SaveData, IcloudFileStorage>
#else
    GenericJsonClass<SaveData, UnityFileStorage>
#endif
{
    public static string SaveDataPath
    {
#if UNITY_SWITCH && !UNITY_EDITOR
        get => "NINTENDO STUFF";
#else
        get => Application.persistentDataPath + "/data." + Extension;
#endif
    }

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
