using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class garagaraController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // UpキーでX軸回転
        if (Input.GetKey("up"))
        {
            transform.Rotate(2, 0, 0, Space.Self);
        }
        // DownキーでX軸回転
        if (Input.GetKey("down"))
        {
            transform.Rotate(-2, 0, 0, Space.Self);
        }
        // Right キーでY軸回転
        if (Input.GetKey("right"))
        {
            transform.Rotate(0, 0, 2, Space.Self);
        }

        //Left キーで左でY軸回転
        if (Input.GetKey("left"))
        {
            transform.Rotate(0, 0, -2, Space.Self);
        }

    }
}
