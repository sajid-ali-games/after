using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemydie : MonoBehaviour
{
    public float health = 100f;
    public float dam = 100f;


    public scoreman score;

    private void Start()
    {
        score = GameObject.FindGameObjectWithTag("score").GetComponent<scoreman>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "PlayerBull")
        {
            health -= dam;
            Destroy(gameObject);
            Destroy(collision.collider.gameObject);
            score.plusScore();
        }

    }
}
