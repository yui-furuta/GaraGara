using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BollObjectScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PushReloadButton(){
        //子オブジェクトを一つずつ取得
        foreach (Transform child in gameObject.transform)
        {
            //削除する
            Destroy(child.gameObject);
        }
    }
}
