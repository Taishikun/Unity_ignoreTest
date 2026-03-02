using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class Explosion : MonoBehaviour
//{
//    public void DestroySelf()
//    {
//        Destroy(gameObject);
//    }
//}


public class Explosion : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 0.5f); // 0.5ïbå„Ç…çÌèú
    }
}
