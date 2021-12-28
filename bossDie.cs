using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class bossDie : MonoBehaviour
{
    public float health = 100f;
    public float dam;
    public Text tx;
    public scoreman man;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "PlayerBull")
        {
            health -= dam;
            Destroy(collision.collider.gameObject);
        }

    }
    private void Update()
    {
        if(health <= 0)
        {
            SceneManager.LoadScene("score");
        }
        tx.text ="<3 :"+ health.ToString();
    }

}
