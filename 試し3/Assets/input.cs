using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class input : MonoBehaviour
{

    // inputfieldを格納する変数
    InputField inputField;

    // テキストを格納する変数
    public Text text;

    public static　string want;

    public　static List<string>tamaList = new List<string>(); //Listの宣言

    // Start is called before the first frame update
    void Start()
    {
        // InputFieldコンポーネントを格納
        inputField = GetComponent<InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        
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

        //リストに文字列を追加
        want = text.text;

        if (want !=null && want.Length!=0) {
            tamaList.Add(want);
            Debug.Log(string.Join(",", tamaList));
        }
    }

   　public void kuzi()
    {

    }


}

public class Tama
{
    public string text;
    public int color;
}
