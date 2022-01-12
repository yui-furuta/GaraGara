using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class randomkuzi1 : MonoBehaviour
{
    //public List<string> tamaList1 = input1.List<string>tamaList1;

    //テキストを格納する変数
    public Text text;

    public string kuzi1;

    GameObject inputField1;
    //input1 var;

    public void randomChoice()
    {
        //inputField1 = GameObject.Find("inputField");
        //var = inputField1.GetComponent<input1>();

        //InputFieldに入力された文字をテキストエリアに表示

        
        kuzi1 = input1.tamaList1.GetAndRemoveAtRandom();

        text.text = kuzi1;

        Debug.Log(string.Join(",", input1.tamaList1));
    }
}
