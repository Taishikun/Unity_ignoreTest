using System.Collections;
using System.Collections.Generic;
//using UnityEngine;


//public class Shooter : MonoBehaviour
//{
//    public ShotBase currentShotPrefab;
//    public Transform shotPoint;
//    public Transform target;

//    void Update()
//    {
//        if (Input.GetKeyDown(KeyCode.Space))
//        {
//            ShotBase shot = Instantiate(currentShotPrefab, shotPoint.position, shotPoint.rotation);
//            shot.Initialize(target);
//        }
//    }
//}


using UnityEngine;

public class Shooter : MonoBehaviour
{
    public ShotBase[] shotPrefabs;   // 弾の種類リスト
    public Transform shotPoint;
    public Transform target;

    private int currentIndex = 0;

    void Update()
    {
        // スペースで発射
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }

        // Qキーで武器切替
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SwitchShot();
        }
    }

    void Fire()
    {
        ShotBase shot = Instantiate(
            shotPrefabs[currentIndex],
            shotPoint.position,
            shotPoint.rotation
        );

        shot.Initialize(target);
    }

    void SwitchShot()
    {
        currentIndex++;
        if (currentIndex >= shotPrefabs.Length)
            currentIndex = 0;

        Debug.Log("現在の武器: " + shotPrefabs[currentIndex].name);
    }
}
