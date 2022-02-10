using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;//追加
using UnityEngine.UI;

public class ScrollViewButton : MonoBehaviour
{

    public GameObject nodeObject;
    public GameObject content;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PushScrollButton(){
        GameObject obj = Instantiate(nodeObject,Vector3.zero,Quaternion.identity);
        obj.transform.parent = content.transform;
    }
}
