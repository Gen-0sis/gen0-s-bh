using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float turnSpeed;
    [SerializeField] float delay = .5f;
    [SerializeField] GameObject[] spawnPoints;
    float time = 0;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time >= delay)
        {
            time = 0;
            for (int i = 0; i < spawnPoints.Length; i++)
            {
                GameObject clone = Instantiate(bulletPrefab, spawnPoints[i].transform.position, spawnPoints[i].transform.localRotation * transform.rotation);
                clone.GetComponent<BulletController>().direction = transform.rotation;
            }
        }
        transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
    }
}
