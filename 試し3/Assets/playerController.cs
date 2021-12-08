using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    Rigidbody rb;

    float moveH;

    float moveV;

    Vector3 move;

    public GameObject gameclea;

    //public float speedratio;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //moveH = Input.GetAxis("Horizontal");

        //moveV = Input.GetAxis("Vertical");

        move = new Vector3(moveH, 0, moveV);

        rb.AddForce(move);
    }

    private void OnTriggerEnter(Collider other)
    {
        //gameclea.GetComponent<Text>();
        other.gameObject.SetActive(false);
        gameclea.SetActive(true);
    }
}
