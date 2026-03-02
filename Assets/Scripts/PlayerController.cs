using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    float jumpForce = 400.0f;
    //float walkForce = 20.0f;
    float maxWalkSpeed = 2.0f;

    private bool isOnCloud = false;
    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if(Input.GetKeyDown(KeyCode.Space))
    //    {
    //        this.rigid2D.AddForce(transform.up * this.jumpForce);
    //    }

    //    int key = 0;
    //    if (Input.GetKey(KeyCode.RightArrow)) key = 1;
    //    if (Input.GetKey(KeyCode.LeftArrow)) key = -1;
    //    float speedx = Mathf.Abs(this.rigid2D.velocity.x);
    //    if(speedx < this.maxWalkSpeed)
    //    {
    //        this.rigid2D.AddForce(transform.right * key * this.walkForce);
    //    }

    //    // ‰æ‘œ‚Ì”½“]
    //    if(key !=0)
    //    { 
    //        transform.localScale = new Vector3(key, 1, 1);
    //    }

    //    this.animator.speed = speedx / 4.0f;
    //}


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& isOnCloud)
        {
            this.rigid2D.AddForce(Vector2.up * this.jumpForce);
        }

        float key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        // ’¼Ú‘¬“x‚ð§Œä
        Vector2 velocity = rigid2D.velocity;
        velocity.x = key * maxWalkSpeed;
        rigid2D.velocity = velocity;

        // ‰æ‘œ”½“]
        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        // ƒŠƒXƒ|[ƒ“
        Vector2 position = rigid2D.position;
        if (position.y < -10.0f)
        {
            rigid2D.position = new Vector3(0, 0.2f, 1);
        }



        animator.speed = Mathf.Abs(velocity.x) / maxWalkSpeed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Cloud"))
        {
            isOnCloud = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Cloud"))
        {
            isOnCloud = false;
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Cloud"))
        {
            foreach (ContactPoint2D point in collision.contacts)
            {
                if (point.normal.y > 0.5f)
                {
                    isOnCloud = true;
                    return;
                }
            }
        }

        isOnCloud = false;
    }



}
