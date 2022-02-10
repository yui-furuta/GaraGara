using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class wallChange : MonoBehaviour
{

    [SerializeField] GameObject pink;
    [SerializeField] GameObject green;
    [SerializeField] GameObject yellow;
    [SerializeField] GameObject blue;
    [SerializeField] GameObject orange;
    [SerializeField] GameObject gray;

    // Start is called before the first frame update
    void Start()
    {
        pushPink();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pushPink(){
        pink.SetActive(true);
        green.SetActive(false);
        yellow.SetActive(false);
        blue.SetActive(false);
        orange.SetActive(false);
        gray.SetActive(false);
    }

    public void pushGreen(){
        pink.SetActive(false);
        green.SetActive(true);
        yellow.SetActive(false);
        blue.SetActive(false);
        orange.SetActive(false);
        gray.SetActive(false);
    }

    public void pushYellow(){
        pink.SetActive(false);
        green.SetActive(false);
        yellow.SetActive(true);
        blue.SetActive(false);
        orange.SetActive(false);
        gray.SetActive(false);
    }

    public void pushBlue(){
        pink.SetActive(false);
        green.SetActive(false);
        yellow.SetActive(false);
        blue.SetActive(true);
        orange.SetActive(false);
        gray.SetActive(false);
    }

    public void pushOrange(){
        pink.SetActive(false);
        green.SetActive(false);
        yellow.SetActive(false);
        blue.SetActive(false);
        orange.SetActive(true);
        gray.SetActive(false);
    }

    public void pushGray(){
        pink.SetActive(false);
        green.SetActive(false);
        yellow.SetActive(false);
        blue.SetActive(false);
        orange.SetActive(false);
        gray.SetActive(true);
    }
}
