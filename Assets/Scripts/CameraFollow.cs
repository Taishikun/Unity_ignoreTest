using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;   // Cat‚ð“ü‚ê‚é
    [SerializeField] private float smoothSpeed = 5f;
    [SerializeField] private Vector2 offset;

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + new Vector3(offset.x,offset.y,-1);
        Vector3 smoothedPosition = Vector3.Lerp(
            transform.position,
            desiredPosition,
            smoothSpeed * Time.deltaTime);

        transform.position = smoothedPosition;
    }
}
