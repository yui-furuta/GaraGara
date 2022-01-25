using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class UIManeger : MonoBehaviour
{
    //３つのPanelを格納する変数
    //インスペクターウィンドウからゲームオブジェクトを設定する
    [SerializeField] GameObject TopPanel;
    [SerializeField] GameObject GaraponPanel;
    [SerializeField] GameObject InputPanel;
    [SerializeField] GameObject KuziPanel;
    [SerializeField] GameObject HelpGaraponPanel;



    // Start is called before the first frame update
    void Start()
    {
        //BackToMenuメソッドを呼び出す
        BackToTop();
    }


    //MenuPanelでXR-HubButtonが押されたときの処理
    //XR-HubPanelをアクティブにする
    public void SelectGaraponDescription()
    {
        TopPanel.SetActive(false);
        GaraponPanel.SetActive(true);
    }


    //MenuPanelでUnityButtonが押されたときの処理
    //UnityPanelをアクティブにする
    public void SelectInputDescription()
    {
        TopPanel.SetActive(false);
        InputPanel.SetActive(true);
    }


    //2つのDescriptionPanelでBackButtonが押されたときの処理
    //MenuPanelをアクティブにする
    public void BackToTop()
    {
        TopPanel.SetActive(true);
        GaraponPanel.SetActive(false);
        InputPanel.SetActive(false);
        KuziPanel.SetActive(false);
    }

    public void KuziChoice(){
        KuziPanel.SetActive(true);
        GaraponPanel.SetActive(false);
    }

    public void BackToGarapon()
    {
        KuziPanel.SetActive(false);
        GaraponPanel.SetActive(true);
    }
    public void HelpGarapon()
    {
        HelpGaraponPanel.SetActive(true);
    }
    public void BackHelpGarapon()
    {
        HelpGaraponPanel.SetActive(false);
    }
}
