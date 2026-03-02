//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class FlagMove : MonoBehaviour
//{
//    // Start is called before the first frame update
//    void Start()
//    {
        
//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }
//}

using UnityEngine;

public class FlagMove : MonoBehaviour
{
    public float amplitude = 1.0f;   // U‚ê•
    public float speed = 2.0f;       // ‘¬‚³

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position; // ‰ŠúˆÊ’u‚ğ•Û‘¶
    }

    void Update()
    {
        float y = Mathf.Sin(Time.time * speed) * amplitude;
        transform.position = startPos + new Vector3(0, y, 0);
    }
}
