using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEffect01 : MonoBehaviour
{

    public GameObject hitEffectPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        float hitSpeed = collision.relativeVelocity.magnitude;

        if (hitSpeed < 5f) return; // Õ“Ë‚Ì‹­‚³è‡’l

        Vector2 hitPos = collision.contacts[0].point;
        Vector2 normal = collision.contacts[0].normal;
        Quaternion rot = Quaternion.FromToRotation(Vector2.up, normal);

        GameObject effect = Instantiate(hitEffectPrefab, hitPos, rot);

        ParticleSystem ps = effect.GetComponent<ParticleSystem>();

        int amount = Mathf.Clamp(Mathf.RoundToInt(hitSpeed * 3f), 5, 50);
        ps.Emit(amount);
    }



}
