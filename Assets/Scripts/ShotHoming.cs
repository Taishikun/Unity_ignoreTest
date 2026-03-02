
using UnityEngine;

public class ShotHoming : ShotBase
{
    public float rotateSpeed = 200f;

    protected override void Move()
    {
        if (target == null)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            return;
        }

        Vector2 direction = (target.position - transform.position).normalized;
        float rotateAmount = Vector3.Cross(direction, transform.right).z;
        transform.Rotate(0, 0, -rotateAmount * rotateSpeed * Time.deltaTime);

        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}
