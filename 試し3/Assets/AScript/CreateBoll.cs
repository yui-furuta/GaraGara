using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBoll : MonoBehaviour
{

    public GameObject Boll;

    public void CubeCreate()
    {
        GameObject obj = Instantiate(Boll, new Vector3(0, 0, 100), Quaternion.identity);
        obj.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, 1.0f);

    }
}
