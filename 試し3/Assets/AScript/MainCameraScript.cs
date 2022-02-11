using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;


public class MainCameraScript : MonoBehaviour
{
    [SerializeField] GameObject TopPanel;
    [SerializeField] GameObject GaraponPanel;
    [SerializeField] GameObject InputPanel;
    [SerializeField] GameObject KuziPanel;


    // Update is called once per frame
    void Update()
    {
         // ワールド座標を基準に、座標を取得
        Transform myTransform = this.transform;
        Vector3 localPos = myTransform.localPosition;
        if(TopPanel.activeSelf == true){
        localPos.x = 0f;    // ワールド座標を基準にした、x座標を1に変更
        localPos.y = 0.8f;    // ワールド座標を基準にした、y座標を1に変更
        localPos.z = -170f;    // ワールド座標を基準にした、z座標を1に変更
        myTransform.localPosition = localPos; // ローカル座標での座標を設定
        }
        if(GaraponPanel.activeSelf == true){
        localPos.x = 0f;    // ワールド座標を基準にした、x座標を1に変更
        localPos.y = 0.8f;    // ワールド座標を基準にした、y座標を1に変更
        localPos.z = -113f;    // ワールド座標を基準にした、z座標を1に変更
        myTransform.localPosition = localPos; // ローカル座標での座標を設定
        }
        if(InputPanel.activeSelf == true){
        localPos.x = 0f;    // ワールド座標を基準にした、x座標を1に変更
        localPos.y = 32f;    // ワールド座標を基準にした、y座標を1に変更
        localPos.z = -65f;    // ワールド座標を基準にした、z座標を1に変更
        myTransform.localPosition = localPos; // ローカル座標での座標を設定
        }
        if(KuziPanel.activeSelf == true){
        localPos.x = 0f;    // ワールド座標を基準にした、x座標を1に変更
        localPos.y = 0.8f;    // ワールド座標を基準にした、y座標を1に変更
        localPos.z = -113f;    // ワールド座標を基準にした、z座標を1に変更
        myTransform.localPosition = localPos; // ローカル座標での座標を設定
        }
        
    }
}
