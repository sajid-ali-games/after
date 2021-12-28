using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossbullet : MonoBehaviour
{
    public float speed;
    public float life;
    public Transform tr;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {

        tr = GameObject.FindGameObjectWithTag("spawn").transform;
        rb = GetComponent<Rigidbody>();
        rb.AddForce(tr.forward * speed * Time.deltaTime);


    }

    // Update is called once per frame
    void Update()
    {
        life -= Time.deltaTime;
        // transform.position += tr.forward * speed * Time.deltaTime;



        if (life <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
