using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class list : MonoBehaviour
{

    private List<TamaClass> tamaList = new List<TamaClass>(); //Listの宣言
                                                    //int number = 1;

    // Start is called before the first frame update
    void Start()
    {

        TamaClass tama1 = new TamaClass();
        tama1.text = "課題";
        tama1.color = 200;
        tamaList.Add(tama1);

        TamaClass tama2 = new TamaClass();
        tama2.text = "読書";
        tama2.color = 100;
        tamaList.Add(tama2);


    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 2; i++)
        {
            Debug.Log(tamaList[i].text);
        }
    }

}

public class TamaClass
{
    public string text;
    public int color;
}
