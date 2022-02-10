using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class ConentBuild : MonoBehaviour
{
    [SerializeField]
	RectTransform prefab = null;
    [SerializeField] GameObject ListPanel;

    [SerializeField]
    private GameObject ParentObject;
    private GameObject[] ChildObject;

    // Start is called before the first frame update
    void Start()
    {
        // var item = GameObject.Instantiate(prefab) as RectTransform;
		// item.SetParent(transform, false);
    }

    // Update is called once per frame
    void Update()
    {
        if(ListPanel.activeSelf == true){
           contentLoad();
        }
    }

    public void contentLoad(){
       // SaveData saveData = Load();
        Debug.Log(string.Join(",", inputBuild.testList));
    }

    public void pushContentButton(){
       // SaveData saveData = Load();
        for(int i=0; i<inputBuild.testList.Count; i++){
        string v = inputBuild.testList[i];
        //Debug.Log(v);
        var item = GameObject.Instantiate(prefab) as RectTransform;
		item.SetParent(transform, false);

        var text = item.GetComponentInChildren<Text>();
	    text.text = v;
        }
    }

    public void pushLoadContentButton(){
        //SaveData saveData = Load();
        inputBuild.testList.Clear();

        ChildObject = new GameObject[ParentObject.transform.childCount];

        for (int i = 0; i < ParentObject.transform.childCount; i++)
        {
            ChildObject[i] = ParentObject.transform.GetChild(i).gameObject;
            var text = ChildObject[i].GetComponentInChildren<Text>();
            inputBuild.testList.Add(text.text);
        }
        Debug.Log(string.Join(",", inputBuild.testList));
        //Save(saveData);
         foreach (Transform child in gameObject.transform)
        {
            //削除する
            Destroy(child.gameObject);
        }

        // for(int i=0; i<saveData.tamaList.Count; i++){
        // string v = saveData.tamaList[i];
        // Debug.Log(v);
        // var item = GameObject.Instantiate(prefab) as RectTransform;
		// item.SetParent(transform, false);

        // var text = item.GetComponentInChildren<Text>();
	    // text.text = v;
        //}
    }
}
