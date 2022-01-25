using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;//追加
using UnityEngine.UI;


public class BuildRandomkuzi : MonoBehaviour
{

    //テキストを格納する変数
    public Text text;

    public string kuzi;

    GameObject inputField;

    public GameObject Boll;

    public GameObject BollObject;

    public float r=0f;
    public float g=0f;
    public float b=0f;
    public float a=0f;

    public Image image;

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
        string v = input.testList.GetAndRemoveAtRandom();
        kuzi = v;
        text.text = kuzi;
        Debug.Log(string.Join(",",input.testList));

        r = PlayerControllerBuild.bollColor.r;
        g = PlayerControllerBuild.bollColor.g;
        b = PlayerControllerBuild.bollColor.b;
        a = PlayerControllerBuild.bollColor.a;
        Debug.Log(r);
        image.color = new Color(r,g,b,a);
    }

    // テストリストこルーチン
    private IEnumerator SpawnBuild()
    {
        for(int i=0; i<input.testList.Count; i++){
           GameObject obj = Instantiate(Boll, new Vector3(0, 20, 100), Quaternion.identity);
           obj.transform.parent = BollObject.transform;
           obj.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, 1.0f);
           // 1秒待つ
            yield return new WaitForSeconds(0.5f); 
            // もし3回生成済だったらコルーチン終了
            if (i == input.testList.Count) 
            {
                yield break;
            }
        }
    }

    public void PushResetButton()
    {
        // コルーチン開始
        StartCoroutine("SpawnBuild"); 
    }
}
