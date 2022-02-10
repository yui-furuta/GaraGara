using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class content : MonoBehaviour
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

    public void Save(SaveData saveData)
    {
        StreamWriter writer;

        string jsonstr = JsonUtility.ToJson(saveData);

        writer = new StreamWriter(Application.dataPath + "/savedata.json", false);
        writer.Write(jsonstr);
        writer.Flush();
        writer.Close();
    }

    public SaveData Load()
    {
        if (File.Exists(Application.dataPath + "/savedata.json"))
        {
            string datastr = "";
            StreamReader reader;
            reader = new StreamReader(Application.dataPath + "/savedata.json");
            datastr = reader.ReadToEnd();
            reader.Close();
            return JsonUtility.FromJson<SaveData>(datastr);
        }

        SaveData saveData = new SaveData();
        return saveData;
    }

    public void contentLoad(){
        SaveData saveData = Load();
        Debug.Log(string.Join(",", saveData.tamaList));
    }

    // // たまリストこルーチン
    // private IEnumerator SpawnContent()
    // {
    //     SaveData saveData = Load();
    //     for(int i=0; i<saveData.tamaList.Count; i++){
    //        var item = GameObject.Instantiate(prefab) as RectTransform;
	// 	   item.SetParent(transform, false);
    //        // 1秒待つ
    //         yield return new WaitForSeconds(0.1f); 
    //         // リストの数分生成済だったらコルーチン終了
    //         if (i == saveData.tamaList.Count)
    //         {
    //             yield break;
    //         }
    //     }
    //     Debug.Log(string.Join(",", saveData.tamaList));
    // }

    public void pushContentButton(){
        SaveData saveData = Load();
        for(int i=0; i<saveData.tamaList.Count; i++){
        string v = saveData.tamaList[i];
        //Debug.Log(v);
        var item = GameObject.Instantiate(prefab) as RectTransform;
		item.SetParent(transform, false);

        var text = item.GetComponentInChildren<Text>();
	    text.text = v;
        }
    }

    public void pushLoadContentButton(){
        SaveData saveData = Load();
        saveData.tamaList.Clear();

        ChildObject = new GameObject[ParentObject.transform.childCount];

        for (int i = 0; i < ParentObject.transform.childCount; i++)
        {
            ChildObject[i] = ParentObject.transform.GetChild(i).gameObject;
            var text = ChildObject[i].GetComponentInChildren<Text>();
            saveData.tamaList.Add(text.text);
        }
        Debug.Log(string.Join(",", saveData.tamaList));
        Save(saveData);
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
