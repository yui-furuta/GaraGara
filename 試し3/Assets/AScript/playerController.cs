using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;


public class playerController : MonoBehaviour
{
    Rigidbody rb;

    float moveH;

    float moveV;

    Vector3 move;

    public GameObject gameclea;

    public GameObject kuzi;
    public GameObject kuzipanel;

    // [SerializeField] GameObject TopPanel;
    // [SerializeField] GameObject GaraponPanel;
    // [SerializeField] GameObject InputPanel;
    // [SerializeField] GameObject KuziPanel;

    //public float speedratio;
    // Start is called before the first frame update
    void Start()
    {
        // rb = GetComponent<Rigidbody>();
        kuzi = GameObject.Find("kuzi");
        kuzipanel = GameObject.Find("UIManeger");
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
            Destroy(gameObject);
            kuzi.GetComponent<randomkuzi>().randomChoice();
            kuzipanel.GetComponent<UIManeger>().KuziChoice();
        }

        // }
        // else{
        //     move = new Vector3(0, 20, 100);
        // }
        //gameclea.GetComponent<Text>();
        // this.gameObject.SetActive(false);
        // gameclea.SetActive(true);
    }
    
}
