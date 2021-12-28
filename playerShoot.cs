using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour
{
    public GameObject PlayerBull;
    public Transform tr;
    public float off;

    // Start is called before the first frame update
    void Start()
    {
        tr = GameObject.FindGameObjectWithTag("spawn").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input .GetKeyDown(KeyCode.Space))
        {
            Instantiate(PlayerBull ,tr.position + tr.forward * off * Time.deltaTime,Quaternion .identity);
        }
        
    }
}
