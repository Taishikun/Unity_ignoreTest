using UnityEngine;

public class RocketMove : MonoBehaviour
{
    public float moveSpeed = 4f;
    public float rotateSpeed = 200f;

    public GameObject hitEffectPrefab;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 回転
        float rotateInput = Input.GetAxis("Horizontal");
        rb.angularVelocity = -rotateInput * rotateSpeed;

        // 前進
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(transform.up * moveSpeed);
        }
    }

    //void OnCollisionEnter2D(Collision2D collision)
    //{
    //    // 衝突位置を取得
    //    Vector2 hitPos = collision.contacts[0].point;

    //    // パーティクル生成
    //    Instantiate(hitEffectPrefab, hitPos, Quaternion.identity);
    //    // 自分を消す
    //    //Destroy(gameObject);
    //}
    void OnCollisionEnter2D(Collision2D collision)
    {
        float hitSpeed = collision.relativeVelocity.magnitude;

        if (hitSpeed < 5f) return; // 衝突の強さ閾値

        Vector2 hitPos = collision.contacts[0].point;
        Vector2 normal = collision.contacts[0].normal;
        Quaternion rot = Quaternion.FromToRotation(Vector2.up, normal);

        GameObject effect = Instantiate(hitEffectPrefab, hitPos, rot);

        ParticleSystem ps = effect.GetComponent<ParticleSystem>();

        int amount = Mathf.Clamp(Mathf.RoundToInt(hitSpeed * 3f), 5, 50);
        ps.Emit(amount);
    }


}
