using UnityEngine;

public class UFOMove : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x < -13)
        {
            Vector3 pos = transform.position;
            pos.x = 13;
            float top = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;
            float bottom = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;

            float randomY = Random.Range(bottom, top);
            pos.y = randomY;


            transform.position = pos;
        }
    }
}
