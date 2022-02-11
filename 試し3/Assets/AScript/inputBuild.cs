using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;//追加
using UnityEngine.UI;

public class inputBuild : MonoBehaviour
{
    // inputfieldを格納する変数
    InputField inputFieldBuild;

    // テキストを格納する変数
    public Text text;

    public Text listText;

    public static string want;

    //ボール
    public GameObject BollBuild;

    public GameObject BollObjectBuild;

    public static List<string>testList = new List<string>(); //Listの宣言

    // Start is called before the first frame update
    void Start()
    {
        // InputFieldコンポーネントを格納
        inputFieldBuild = GetComponent<InputField>();
    }

    public string add;

    public void DisplayTextBuild()
    {
         //InputFieldに入力された文字を取得
        Text FieldText = GameObject.Find("InputField(Build)/Text").GetComponent<Text>();
        
        //InputFieldに入力された文字をテキストエリアに表示
        text.text = FieldText.text;

        //InputField内の文字をクリア
        InputField column = GameObject.Find("InputField(Build)").GetComponent<InputField>();
        column.text = "";

        //リストに文字列を
        want = text.text;
        //Debug.Log(want);

        if (want !=null && want.Length!=0) {
            testList.Add(want);
            Debug.Log(string.Join(",",testList));
           // Debug.Log(want);
            GameObject obj = Instantiate(BollBuild, new Vector3(0, 20, 100), Quaternion.identity);
            obj.transform.parent = BollObjectBuild.transform;
            obj.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, 1.0f);
            //listText.text = string.Join(",", saveData.tamaList);
        }
    }
}
