using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class CameraScript : MonoBehaviour
{
    [SerializeField] GameObject TopPanel;
    [SerializeField] GameObject GaraponPanel;
    [SerializeField] GameObject InputPanel;
    [SerializeField] GameObject KuziPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform2 = this.transform;
        Vector3 worldPos = myTransform2.eulerAngles;
        if (TopPanel.activeSelf == true){
        transform.Rotate ( 0, 1, 0 );
        }
        if (GaraponPanel.activeSelf == true){
        worldPos.x = 0f;   // ワールド座標を基準にした、x座標を1に変更
        worldPos.y = 0f;   // ワールド座標を基準にした、y座標を1に変更
        worldPos.z = 0f;   // ワールド座標を基準にした、z座標を1に変更
        myTransform2.eulerAngles = worldPos; // ローカル座標での座標を設定
        }
        if (InputPanel.activeSelf == true){
        worldPos.x = 0f;   // ワールド座標を基準にした、x座標を1に変更
        worldPos.y = 0f;   // ワールド座標を基準にした、y座標を1に変更
        worldPos.z = 0f;   // ワールド座標を基準にした、z座標を1に変更
        myTransform2.eulerAngles = worldPos; // ローカル座標での座標を設定
        }
        if (KuziPanel.activeSelf == true){
        worldPos.x = 0f;   // ワールド座標を基準にした、x座標を1に変更
        worldPos.y = 0f;   // ワールド座標を基準にした、y座標を1に変更
        worldPos.z = 0f;   // ワールド座標を基準にした、z座標を1に変更
        myTransform2.eulerAngles = worldPos; // ローカル座標での座標を設定
        }
    }
}
