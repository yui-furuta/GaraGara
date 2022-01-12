using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class InputSave : MonoBehaviour
{
    // inputfieldを格納する変数
    InputField inputField;

    public static string todo;

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

    public void ListAdd()
    {
        //InputFieldに入力された文字を取得
        Text FieldText = GameObject.Find("InputField/Text").GetComponent<Text>();

        todo = FieldText.text;

        //InputField内の文字をクリア
        InputField column = GameObject.Find("InputField").GetComponent<InputField>();
        column.text = "";

        //Debug.Log(todo);
    }
}
