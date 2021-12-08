using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeGenerate : MonoBehaviour
{
    bool generate;

      // Use this for initialization
    void Start () {
        // // CubeプレハブをGameObject型で取得
        // GameObject obj = (GameObject)Resources.Load ("Cube");
        // // Cubeプレハブを元に、インスタンスを生成、
        // Instantiate (obj, new Vector3(0.0f,2.0f,0.0f), Quaternion.identity);
    }

     public void CubeSet()
     {
        // CubeプレハブをGameObject型で取得
        GameObject obj = (GameObject)Resources.Load ("Cube");
        // Cubeプレハブを元に、インスタンスを生成、
        Instantiate (obj, new Vector3(0.0f,2.0f,0.0f), Quaternion.identity);
     }
 
}
