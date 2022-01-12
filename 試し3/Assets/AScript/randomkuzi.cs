using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;//追加
using UnityEngine.UI;

public class randomkuzi : MonoBehaviour
{
    //public List<string> tamaList = input.List<string>tamaList;

    //テキストを格納する変数
    public Text text;

    public string kuzi;

    GameObject inputField;
    //input var;

    public GameObject Boll;

    float countx = 0;

    float county = 0;

    void Start(){
         SaveData saveData = Load();
        for(int i=0; i<saveData.tamaList.Count; i++){
            GameObject obj = Instantiate(Boll, new Vector3(countx-i*2, county, 100), Quaternion.identity);
            obj.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, 1.0f);
            if(i%10 == 0){
                countx = countx - 15;
                county = county - 5;
            }
        }
    }

    public void Save(SaveData saveData)
    {
        StreamWriter writer;

        string jsonstr = JsonUtility.ToJson(saveData);

        writer = new StreamWriter(Application.dataPath + "/savedata.json", false);
        writer.Write(jsonstr);
        writer.Flush();
        writer.Close();
    }

    public SaveData Load()
    {
        if (File.Exists(Application.dataPath + "/savedata.json"))
        {
            string datastr = "";
            StreamReader reader;
            reader = new StreamReader(Application.dataPath + "/savedata.json");
            datastr = reader.ReadToEnd();
            reader.Close();

            return JsonUtility.FromJson<SaveData>(datastr);
        }

        SaveData saveData = new SaveData();
        //saveData.player_name = "";
        //saveData.player_level = 1;
        return saveData;
    }

    public void randomChoice()
    {
        //inputField = GameObject.Find("inputField");
        //var = inputField.GetComponent<input>();

        //InputFieldに入力された文字をテキストエリアに表示

        SaveData saveData = Load();
        string v = saveData.tamaList.GetAndRemoveAtRandom();
        kuzi = v;
        text.text = kuzi;
        Save(saveData);
        Debug.Log(string.Join(",", saveData.tamaList));
    }
}
