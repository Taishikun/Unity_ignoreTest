using UnityEngine;

public class WallRotate : MonoBehaviour
{
    public float rotateSpeed = 200f;
    private Rigidbody2D rb;
    private float input;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        input = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        rb.angularVelocity = -input * rotateSpeed;
    }
}
