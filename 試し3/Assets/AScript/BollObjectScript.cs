using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BollObjectScript : MonoBehaviour
{

    public GameObject targetObject;
    public GameObject ResetObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform targetTransform = targetObject.transform;
        Vector3 worldAngle = targetTransform.eulerAngles;
        Vector3 worldPos = targetTransform.position;
        //Debug.Log(worldPos.x+","+worldPos.y+","+worldPos.z);
    }

    public void PushReloadButton(){
        //子オブジェクトを一つずつ取得
        foreach (Transform child in gameObject.transform)
        {
            //削除する
            Destroy(child.gameObject);
        }
    }

    public void PushKuziButton(){
        Transform ResetTransform = ResetObject.transform;
        Vector3 worldPos = ResetTransform.position;
        GameObject obj = transform.GetChild(Random.Range(0, transform.childCount)).gameObject;
        obj.transform.position = new Vector3(worldPos.x, worldPos.y, worldPos.z);
        // Destroy(transform.GetChild(Random.Range(0, transform.childCount)).gameObject);
    }

    public void PushReloadListButton(){
        //子オブジェクトを一つずつ取得
        foreach (Transform child in gameObject.transform)
        {
            //削除する
            Destroy(child.gameObject);
        }
    }
}
