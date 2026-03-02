using UnityEngine;

public class CloudMove : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float moveDistance = 3f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
        this.startPos=Vector3.zero;
    }
    
    

    void Update()
    {
        float move = Mathf.Sin(Time.time) * moveDistance;
        transform.position = startPos + new Vector3(move, 0, 0);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(transform);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    }
}
