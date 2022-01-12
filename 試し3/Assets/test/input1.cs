using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;



public class input1 : MonoBehaviour
{
    // inputfieldを格納する変数
    InputField inputField1;

    // テキストを格納する変数
    public Text text;

    public string want1;
    public static List<string> tamaList1 = new List<string>(); //Listの宣言

    // Start is called before the first frame update
    void Start()
    {
        // InputFieldコンポーネントを格納
        inputField1 = GetComponent<InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string add;//


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
        want1 = text.text;

        if (want1 !=null && want1.Length!=0) {
            tamaList1.Add(want1);
            Debug.Log(string.Join(",", tamaList1));
        }

        // if (want !=null && want.Length!=0) {
        //     tamaList.Add(want);
        //     Debug.Log(string.Join(",", tamaList));
        // }
    }

    //public void PushSaveButton()
    //{
    //    SaveData saveData = Load();
    //    add = InputSave.todo;
    //    saveData.TamaList.Add(add);
    //    Save(saveData);
    //    //Debug.Log(InputSave.todo);
    //}
}
