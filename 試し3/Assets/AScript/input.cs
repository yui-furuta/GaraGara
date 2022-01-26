using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;//追加
using UnityEngine.UI;

[System.Serializable]//追
public class SaveData{
 public List<string>tamaList = new List<string>(); //Listの宣言
}

public class input : MonoBehaviour
{
    // inputfieldを格納する変数
    InputField inputField;

    // inputfieldを格納する変数
    InputField inputFieldBuild;

    // テキストを格納する変数
    public Text text;

    public Text listText;

    public static string want;

    //ボール
    public GameObject Boll;
    //public GameObject BollBuild;

    public GameObject BollObject;
    //public GameObject BollObjectBuild;

    //public static List<string>testList = new List<string>(); //Listの宣言

    // Start is called before the first frame update
    void Start()
    {
        // InputFieldコンポーネントを格納
        inputField = GetComponent<InputField>();
        // InputFieldコンポーネントを格納
        inputFieldBuild = GetComponent<InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string add;//

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


    public void DisplayText()
    {
         //InputFieldに入力された文字を取得
        Text FieldText = GameObject.Find("InputField/Text").GetComponent<Text>();
        
        //InputFieldに入力された文字をテキストエリアに表示
        text.text = FieldText.text;

        //InputField内の文字をクリア
        InputField column = GameObject.Find("InputField").GetComponent<InputField>();
        column.text = "";

        //リストに文字列を
        want = text.text;
        //Debug.Log(want);

        if (want !=null && want.Length!=0) {
            SaveData saveData = Load();
            saveData.tamaList.Add(want);
            Save(saveData);
            Debug.Log(string.Join(",", saveData.tamaList));
           // Debug.Log(want);
            GameObject obj = Instantiate(Boll, new Vector3(0, 20, 100), Quaternion.identity);
            obj.transform.parent = BollObject.transform;
            obj.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, 1.0f);
            //listText.text = string.Join(",", saveData.tamaList);
        }
        // if (want !=null && want.Length!=0) {
        //     tamaList.Add(want);
        //     Debug.Log(string.Join(",", tamaList));
        // }
    }

    // public void DisplayTextBuild()
    // {
    //      //InputFieldに入力された文字を取得
    //     Text FieldText = GameObject.Find("InputField(Build)/Text").GetComponent<Text>();
        
    //     //InputFieldに入力された文字をテキストエリアに表示
    //     text.text = FieldText.text;

    //     //InputField内の文字をクリア
    //     InputField column = GameObject.Find("InputField(Build)").GetComponent<InputField>();
    //     column.text = "";

    //     //リストに文字列を
    //     want = text.text;
    //     //Debug.Log(want);

    //     if (want !=null && want.Length!=0) {
    //         input.testList.Add(want);
    //         Debug.Log(string.Join(",", input.testList));
    //        // Debug.Log(want);
    //         GameObject obj = Instantiate(BollBuild, new Vector3(0, 20, 100), Quaternion.identity);
    //         obj.transform.parent = BollObjectBuild.transform;
    //         obj.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, 1.0f);
    //         //listText.text = string.Join(",", saveData.tamaList);
    //     }
    //     // if (want !=null && want.Length!=0) {
    //     //     tamaList.Add(want);
    //     //     Debug.Log(string.Join(",", tamaList));
    //     // }
    // }

    public void PushLoadButton()
    {
        SaveData saveData = Load();
        Debug.Log(string.Join(",", saveData.tamaList));
    }

    // public void Button(){
    //     GameObject obj = Instantiate(Boll, new Vector3(0, 20, 100), Quaternion.identity);
    //     obj.transform.parent = BollObject.transform;
    //     obj.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, 1.0f);
    //     //InputFieldに入力された文字を取得
    //     Text FieldText = GameObject.Find("InputField/Text").GetComponent<Text>();
    //     testList.Add(FieldText.text);
    //     //InputField内の文字をクリア
    //     InputField column = GameObject.Find("InputField").GetComponent<InputField>();
    //     column.text = "";
    //     listText.text = string.Join(",", testList);
    // }
}
