using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class Ballspawner : MonoBehaviour
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

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;

    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            SpawnBall();
        }
    }

    void SpawnBall()
    {
        // ”­¶ˆÊ’uƒ‰ƒ“ƒ_ƒ€
        Vector2 pos = new Vector2(
            Random.Range(-8f, 8f),
            Random.Range(-4f, 4f)
        );

        GameObject ball = Instantiate(ballPrefab, pos, Quaternion.identity);

        // •ûŒüƒ‰ƒ“ƒ_ƒ€
        float angle = Random.Range(0f, 360f);
        Vector2 dir = new Vector2(Mathf.Cos(angle * Mathf.Deg2Rad),
                                  Mathf.Sin(angle * Mathf.Deg2Rad));

        ball.GetComponent<BallMove>().Init(dir);
    }
}
