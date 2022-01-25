using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ImageScript : MonoBehaviour
{
    [SerializeField] GameObject GaraponPanel;

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
        if(GaraponPanel.activeSelf==true){
                    fadeInFunc();
        }
        else{
            UnityEngine.Color tmp = me.GetComponent<Image>().color;
            tmp.a = 0;
            me.GetComponent<Image>().color = tmp;
            flag = 1;
        }

    //     if (Input.touchCount > 0) {
    // // タッチ情報の取得
    // Touch touch = Input.GetTouch(0);

    // if (touch.phase == TouchPhase.Began) {
    //     Debug.Log("押した瞬間");
    // }

    // if (touch.phase == TouchPhase.Ended) {
    // Debug.Log("離した瞬間");
    // }

    // if (touch.phase == TouchPhase.Moved) {
    //     Debug.Log("押しっぱなし");
    // }
    // }
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

        // if (!EventSystem.current.IsPointerOverGameObject (fingerID)) {
        // //フェードイン
        // if (flag == 1)
        // {
        //     UnityEngine.Color tmp = me.GetComponent<Image>().color;
        //     tmp.a = tmp.a + (Time.deltaTime * fadeSpeed);
        //     me.GetComponent<Image>().color = tmp;
        //     Debug.Log(tmp.a);
        //     //1になったらフェードアウト 
        //     if(tmp.a >= 1){
        //         flag = flag -1;
        //     }
        // }
        // //フェードアウト
        // if(flag == 0){
        //     UnityEngine.Color tmp = me.GetComponent<Image>().color;
        //     tmp.a = tmp.a - (Time.deltaTime * fadeSpeed);
        //     me.GetComponent<Image>().color = tmp; 
        //     //０になったらフェードイン
        //     if(tmp.a <= 0){
        //         flag = flag+1;
        //     }
        // }
        // }
        // if (EventSystem.current.IsPointerOverGameObject (fingerID)) {
        //     UnityEngine.Color tmp = me.GetComponent<Image>().color;
        //     tmp.a = 0;
        //     me.GetComponent<Image>().color = tmp;
        // }
    }
}
