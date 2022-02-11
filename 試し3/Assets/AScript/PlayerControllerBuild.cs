using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;


public class PlayerControllerBuild : MonoBehaviour
{
    Rigidbody rb;

    float moveH;

    float moveV;

    Vector3 move;

    public GameObject gameclea;

    public GameObject kuziBuild;
    public GameObject UIManeger;
    //public GameObject KuziPanel;

    public static Color bollColor = new Color(0f, 0f, 0f, 0f);

    void Start()
    {
        // rb = GetComponent<Rigidbody>();
        kuziBuild = GameObject.Find("kuzi(Build)");
        UIManeger = GameObject.Find("UIManeger");
        //KuziPanel = GameObject.Find("KuziPanel");
    }

    // Update is called once per frame
    void Update()
    {
        // moveH = Input.GetAxis("Horizontal");

        // moveV = Input.GetAxis("Vertical");

        // move = new Vector3(moveH, 0, moveV);

        // rb.AddForce(move);
    }

    private void OnTriggerEnter(Collider other)
    {
        // if (GaraponPanel.activeSelf == true){

        if(other.gameObject.tag == "testWall"){
            Material mat = this.GetComponent<Renderer>().material;
            bollColor = mat.color;
            Destroy(gameObject);
            kuziBuild.GetComponent<BuildRandomkuzi>().randomChoice();
            UIManeger.GetComponent<UIManeger>().KuziChoice();
            //KuziPanel.GetComponent<panelColorScript>().Kuzi();
        }
    }
    
}
