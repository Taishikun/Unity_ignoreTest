using UnityEngine;


public class ShotStraight : ShotBase
{
    protected override void Move()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}
