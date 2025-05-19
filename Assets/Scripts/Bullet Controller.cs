using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float speed = 4.0f;
    [SerializeField] float lifespan = 2.0f;
    public int mode = 0;
    public Quaternion direction;
    float time = 0;
    public int size = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.localScale = new Vector3(size,size,size);
    }

    // Update is called once per frame
    void Update()
    {
        switch (mode)
        {
            case 1:
                if (time >= (lifespan / 2))
                {
                    rb.velocity = direction * Vector3.down * (speed/2); 
                    time += Time.deltaTime;
                }
                else
                {
                    rb.velocity = rb.velocity ; //speed up
                    time += Time.deltaTime;
                }
                if (time >= lifespan)
                {
                    Destroy(gameObject);
                }
                break;
            default:
                rb.velocity = direction * Vector3.down * speed; //eventually going to use direction to figure out stuff
                time += Time.deltaTime;
                if (time >= lifespan)
                {
                    Destroy(gameObject);
                }
                break;
        }
        
    }
   /* void C00lUpdate() //i want it to start slow then rapidly speed up, but probably going to make this interesting rq one mo
    {
        rb.velocity = direction * Vector3.down * speed; //eventually going to use direction to figure out stuff
        time += Time.deltaTime;
        if (time >= lifespan)
        {
            Destroy(gameObject);
        }
    }*/
}
