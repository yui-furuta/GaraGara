using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ImageScript : MonoBehaviour
{
    [SerializeField] GameObject GaraponPanel;
    [SerializeField] GameObject HelpGaraponPanel;

    GameObject me; // 自分のオブジェクト取得用変数
    public float fadeStart = 1f; // フェード開始時間
    public bool fadeIn = true; // trueの場合はフェードイン
    public float fadeSpeed = 1f; // フェード速度指定
    public float flag = 1;

    public GameObject ImageObject;
    // Start is called before the first frame update
    void Start()
    {
        me = this.gameObject; // 自分のオブジェクト取得
    }

    // Update is called once per frame
    void Update()
    {
        if(GaraponPanel.activeSelf==true && HelpGaraponPanel.activeSelf == false){
                    fadeInFunc();
        }
        else{
            UnityEngine.Color tmp = me.GetComponent<Image>().color;
            tmp.a = 0;
            me.GetComponent<Image>().color = tmp;
            flag = 1;
        }
    }

    void fadeInFunc()
    {
        if (!EventSystem.current.IsPointerOverGameObject ()) {
        //フェードイン
        if (flag == 1)
        {
            UnityEngine.Color tmp = me.GetComponent<Image>().color;
            tmp.a = tmp.a + (Time.deltaTime * fadeSpeed);
            me.GetComponent<Image>().color = tmp;
            Debug.Log(tmp.a);
            //1になったらフェードアウト 
            if(tmp.a >= 1){
                flag = flag -1;
            }
        }
        //フェードアウト
        if(flag == 0){
            UnityEngine.Color tmp = me.GetComponent<Image>().color;
            tmp.a = tmp.a - (Time.deltaTime * fadeSpeed);
            me.GetComponent<Image>().color = tmp; 
            //０になったらフェードイン
            if(tmp.a <= 0){
                flag = flag+1;
            }
        }
        }
        if (EventSystem.current.IsPointerOverGameObject ()) {
            UnityEngine.Color tmp = me.GetComponent<Image>().color;
            tmp.a = 0;
            me.GetComponent<Image>().color = tmp;
        }

        if (!EventSystem.current.IsPointerOverGameObject (Input.GetTouch(0).fingerId)) {
        //フェードイン
        if (flag == 1)
        {
            UnityEngine.Color tmp = me.GetComponent<Image>().color;
            tmp.a = tmp.a + (Time.deltaTime * fadeSpeed);
            me.GetComponent<Image>().color = tmp;
            Debug.Log(tmp.a);
            //1になったらフェードアウト 
            if(tmp.a >= 1){
                flag = flag -1;
            }
        }
        //フェードアウト
        if(flag == 0){
            UnityEngine.Color tmp = me.GetComponent<Image>().color;
            tmp.a = tmp.a - (Time.deltaTime * fadeSpeed);
            me.GetComponent<Image>().color = tmp; 
            //０になったらフェードイン
            if(tmp.a <= 0){
                flag = flag+1;
            }
        }
        }
        if (EventSystem.current.IsPointerOverGameObject (Input.GetTouch(0).fingerId)) {
            UnityEngine.Color tmp = me.GetComponent<Image>().color;
            tmp.a = 0;
            me.GetComponent<Image>().color = tmp;
        }
    }
}
