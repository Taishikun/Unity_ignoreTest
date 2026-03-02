using UnityEngine;


public class BallMove : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Init(Vector2 dir)
    {
        rb.velocity = dir.normalized * speed;
    }

    //void OnCollisionEnter2D(Collision2D collision)
    //{
    //    float hitSpeed = collision.relativeVelocity.magnitude;

    //    if (hitSpeed < 5f) return; // 衝突の強さ閾値

    //    Vector2 hitPos = collision.contacts[0].point;
    //    Vector2 normal = collision.contacts[0].normal;
    //    Quaternion rot = Quaternion.FromToRotation(Vector2.up, normal);

    //    GameObject effect = Instantiate(hitEffectPrefab, hitPos, rot);

    //    ParticleSystem ps = effect.GetComponent<ParticleSystem>();

    //    int amount = Mathf.Clamp(Mathf.RoundToInt(hitSpeed * 3f), 5, 50);
    //    ps.Emit(amount);
    //}




}


//public class BallMove : MonoBehaviour
//{
//    public float speed = 10.0f;
//    private Rigidbody2D rb;

//    void Start()
//    {
//        rb = GetComponent<Rigidbody2D>();

//        // 0～360度の乱数
//        float angle = Random.Range(0f, 360f);

//        // 角度 → ラジアンに変換
//        float rad = angle * Mathf.Deg2Rad;

//        // 方向ベクトル作成
//        Vector2 dir = new Vector2(Mathf.Cos(rad), Mathf.Sin(rad));

//        rb.velocity = dir * speed;


//        //Vector2 dir = new Vector2(1, 1).normalized;
//        //rb.velocity = dir * speed;
//    }

//}


