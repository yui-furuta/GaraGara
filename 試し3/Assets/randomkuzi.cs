using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class randomkuzi : MonoBehaviour
{
    //public List<string> tamaList = input.List<string>tamaList;

    //テキストを格納する変数
    public Text text;

    public string kuzi;


    GameObject inputField;
    //input var;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void randomChoice()
    {
        //inputField = GameObject.Find("inputField");
        //var = inputField.GetComponent<input>();

        //InputFieldに入力された文字をテキストエリアに表示
        kuzi = input.tamaList.GetAndRemoveAtRandom();

        text.text = kuzi;

        Debug.Log(string.Join(",", input.tamaList));
    }
}
