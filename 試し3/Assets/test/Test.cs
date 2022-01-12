using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

[System.Serializable]
public  class SaveDatatest
{
    public string player_name;
    public int player_level;
    public List<string>TamaList = new List<string>(); //Listの宣言
}



public class Test : MonoBehaviour
{

    public string add;

    public void Save(SaveDatatest saveData)
    {
        StreamWriter writer;

        string jsonstr = JsonUtility.ToJson(saveData);

        writer = new StreamWriter(Application.dataPath + "/savedata.json", false);
        writer.Write(jsonstr);
        writer.Flush();
        writer.Close();
    }

    public SaveDatatest Load()
    {
        if (File.Exists(Application.dataPath + "/savedata.json"))
        {
            string datastr = "";
            StreamReader reader;
            reader = new StreamReader(Application.dataPath + "/savedata.json");
            datastr = reader.ReadToEnd();
            reader.Close();

            return JsonUtility.FromJson<SaveDatatest>(datastr);
        }

        SaveDatatest saveData = new SaveDatatest();
        saveData.player_name = "";
        saveData.player_level = 1;
        return saveData;
    }

     public void PushSaveButton()
    {
        SaveDatatest saveData = Load();
        saveData.player_name = "かみこっぷ";
        saveData.player_level = 2;
        add = InputSave.todo;
        saveData.TamaList.Add(add);
        Save(saveData);
        //Debug.Log(InputSave.todo);
    }

    public void PushLoadButton()
    {
        SaveDatatest saveData = Load();
        Debug.Log(saveData.player_name);
        Debug.Log(saveData.player_level);
        Debug.Log(string.Join(",", saveData.TamaList));
    }
}
