using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public float of;
    public float time;
    float realt;
    
    // Start is called before the first frame update
    void Start()
    {
        realt = time;
    }

    // Update is called once per frame
    void Update()
    {
        realt -= Time.deltaTime;
        if(realt <=0)
        {
            Instantiate(bullet, transform.position + transform .forward * of, Quaternion.identity);
            realt = time;

        }
        
    }
}
