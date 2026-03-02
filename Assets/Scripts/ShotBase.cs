using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShotBase : MonoBehaviour
{
    public float speed = 10f;
    public float lifeTime = 3f;
    public GameObject explosionPrefab;   
    protected Transform target;

    public virtual void Initialize(Transform t = null)
    {
        target = t;
        Destroy(gameObject, lifeTime);
    }

    protected abstract void Move();

    void Update()
    {
        Move();
    }

    // FlagÇ…ìñÇΩÇ¡ÇΩÇ∆Ç´ÇÃèàóù
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Flag"))
        {
            //Destroy(other.gameObject);   // Flagè¡Ç∑
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);         // Shotè¡Ç∑

        }
    }


    //GameObject player = GameObject.FindWithTag("Player");





}
