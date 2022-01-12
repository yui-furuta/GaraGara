// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using System.IO;
// using UnityEngine.UI;

// public class Save : MonoBehaviour
// {

//     public string add;

//     //[System.Serializable]
//     public void Save(SaveData saveData)
//     {
//         StreamWriter writer;

//         string jsonstr = JsonUtility.ToJson(saveData);

//         writer = new StreamWriter(Application.dataPath + "/savedata.json", false);
//         writer.Write(jsonstr);
//         writer.Flush();
//         writer.Close();
//     }

//     public SaveData Load()
//     {
//         if (File.Exists(Application.dataPath + "/savedata.json"))
//         {
//             string datastr = "";
//             StreamReader reader;
//             reader = new StreamReader(Application.dataPath + "/savedata.json");
//             datastr = reader.ReadToEnd();
//             reader.Close();

//             return JsonUtility.FromJson<SaveData>(datastr);
//         }

//         SaveData saveData = new SaveData();
//         //saveData.player_name = "";
//         //saveData.player_level = 1;
//         return saveData;
//     }

//     public void PushSaveButton()
//     {
//         SaveData saveData = Load();
//         if (input.want !=null && input.want.Length!=0) {
//         add = input.want;
//         input.saveData.tamaList.Add(add);
//         Save(saveData);
//         }
//         //Debug.Log(InputSave.todo);
//     }

//     public void PushLoadButton()
//     {
//         SaveData saveData = Load();
//         Debug.Log(string.Join(",",input.tamaList));
//     }
// }
