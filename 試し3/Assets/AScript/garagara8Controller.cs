using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class garagara8Controller : MonoBehaviour
{

    [SerializeField] GameObject GaraponPanel;
    [SerializeField] GameObject HelpGaraponPanel;
    [SerializeField] Text text;

    public float Speed = 0.01f;

    private Vector3 _previousMousePosition;

    Vector2 mPos;
    Vector3 screenSizeHalf;
    float rad;
    float previousRad;
    float tan = 0f;
    float tan1 = 0f;

    public Rigidbody rb;

    public AudioClip sound1;
    AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        screenSizeHalf.x = Screen.width / 2f;
        screenSizeHalf.y = Screen.height / 2f;
        screenSizeHalf.z = 0f;
 
        // マウスの初期位置
        mPos = Input.mousePosition - screenSizeHalf;
        previousRad = Mathf.Atan2(mPos.x, mPos.y);
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    { 
        // 真ん中が(0,0,0)になるようにマウスの位置を取得
        mPos = Input.mousePosition - screenSizeHalf;
 
        float rad = Mathf.Atan2(mPos.x, mPos.y); // 上向きとマウス位置のなす角
        float dRad = rad - previousRad; // 前のフレームの角度との差
 
        tan += Mathf.Tan(dRad); //タンジェント // * mPos.magnitude;
        text.text = dRad + "";
        tan1 = Mathf.Tan(dRad);

        
        previousRad = rad; // 今のフレームの角度を保存
         if(GaraponPanel.activeSelf == true && dRad>0 &&dRad<0.5 && HelpGaraponPanel.activeSelf == false){
            transform.Rotate(tan1*-10,0,0, Space.Self);
            if (!audioSource.isPlaying && dRad > 0.1)
            {
                audioSource.PlayOneShot(sound1);
            }
        }
    }

}

