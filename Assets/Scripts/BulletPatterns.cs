using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPatterns : MonoBehaviour
{
    public int mode;//the number of stars that fire
    public int delay;
    public int difficulty;// 1: just pop in then fire before dipping (left or right selecting any x,y coordinate)      2: pop in fire, pop in again fire, pop in again fire    3:slides across horrizontally while firing (random location that it stops at but that will be broadcasted)
    public GameObject bullet;
    public GameObject center;
    void Start()
    {
        switch (mode) {
            case 0: //just fires a single one as a really general thing that can be reused later on
                GameObject clone = Instantiate(bullet, center.transform.position, center.transform.localRotation);
                break;
            case 1://fires 4
                for (int i = 0; i < 4; i++)
                {
                    GameObject clone2 = Instantiate(bullet, center.transform.position, center.transform.localRotation * Quaternion.Euler(0, 90 * i, 0));
                }
                break;
            case 2://fires 6
                for (int i = 0; i < 6; i++)
                {
                    GameObject clone2 = Instantiate(bullet, center.transform.position, center.transform.localRotation * Quaternion.Euler(0, 60 * i, 0));
                }
                break;
            case 3://fires 5 point star
                for (int i = 0; i < 5; i++)
                {
                    GameObject clone2 = Instantiate(bullet, center.transform.position, center.transform.localRotation * Quaternion.Euler(0, 72 * i, 0));
                }
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch (difficulty) {
            case 1:

                break;
            case 2:

                break;
            case 3:

                break;

        }
    
    }
}
