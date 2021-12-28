using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public float lowX;
    public float highX;
    public float lowZ;
    public float highZ;
    public float justY;

    public float time;
    public float realt;

    public GameObject enemy;

    private void Start()
    {
        realt = time;
    }
    void Update()
    {
        realt -= Time.deltaTime;
        Vector3 x = new Vector3(Random.Range(lowX, highX), justY, Random.Range(lowZ, highZ));

        if (realt <= 0)
        {
            Instantiate(enemy, x, Quaternion.identity);
            realt = time;
        }
        
    }
}
