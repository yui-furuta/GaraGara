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

        //Vector3 t = new Vector3();

        //t.z = Mathf.Clamp(Mathf.Tan(dRad) / 10f, -0.3f, 0.3f);

        //rb.AddTorque(transform.TransformDirection(t), ForceMode.Impulse);

        
        previousRad = rad; // 今のフレームの角度を保存

         if(GaraponPanel.activeSelf == true && dRad>0 &&dRad<0.5 && HelpGaraponPanel.activeSelf == false){
            transform.Rotate(tan1*-10,0,0, Space.Self);
        }

        //ベクトルの回転
        //   if (Input.GetMouseButtonDown(0))
        // {
        //     // クリック開始
        //     Debug.Log("Begin");

        //     // 前のフレームのマウス座標を保持する
        //     _previousMousePosition = Input.mousePosition;
        // }
        // else if (Input.GetMouseButton(0))
        // {
        //     // クリック移動
        //     Debug.Log("Moved");

        //     // 現在のマウス座標を取得
        //     var currentMousePosition = Input.mousePosition;
        //     // 前のフレームのマウス座標から現在のマウス座標へのベクトルを求める
        //     var deltaMousePosition = _previousMousePosition - currentMousePosition;
        //     //移動量に応じて角度計算
        //     // * 10はSpeedを調整すれば良いため不要なので削除
        //     float xAngle = deltaMousePosition.y * Speed;
        //     float yAngle = -deltaMousePosition.x * Speed;
        //     float zAngle = 0f;

        //     //回転
        //     transform.Rotate(0, 0, zAngle, Space.World);

        //     // 前のフレームのマウス座標を現在のマウス座標に更新する
        //     _previousMousePosition = currentMousePosition;
        // }
        // else if (Input.GetMouseButtonUp(0))
        // {
        //     // クリック終了
        //     Debug.Log("Ended");
        // }


        //スマホタッチ
        // int touchCount = Input.touches
        // .Count(t => t.phase != TouchPhase.Ended && t.phase != TouchPhase.Canceled);

        // if (touchCount == 1)
        // {
        // Touch t = Input.touches.First();
        // switch (t.phase)
        // {
        // case TouchPhase.Moved:

        // //移動量に応じて角度計算
        // float xAngle = t.deltaPosition.y * Speed * 10;
        // float yAngle = -t.deltaPosition.x * Speed * 10;
        // float zAngle = 0;

        // //回転
        // transform.Rotate(xAngle, yAngle, zAngle, Space.World);

        // break;
        // }

        // }


        // if(GaraponPanel.activeSelf == true){
        // // Right キーでY軸回転
        // if (Input.GetKey("right"))
        // {
        //     transform.Rotate(0, 0, 2, Space.Self);
        // }

        // //Left キーで左でY軸回転
        // if (Input.GetKey("left"))
        // {
        //     transform.Rotate(0, 0, -2, Space.Self);
        // }
        // }
    }

}

