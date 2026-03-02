using System.Collections;

using UnityEngine;

public class CloudScale : MonoBehaviour
{
    public float scaleAmplitude = 0.2f;  // 拡大・縮小の大きさ
    public float scaleSpeed = 1.0f;      // 変化スピード

    private Vector3 baseScale;

    void Start()
    {
        baseScale = transform.localScale;
    }

    void Update()
    {
        float scaleOffset = Mathf.Sin(Time.time * scaleSpeed) * scaleAmplitude;
        transform.localScale = baseScale + Vector3.one * scaleOffset;
    }


}
