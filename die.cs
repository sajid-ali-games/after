using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class die : MonoBehaviour
{
    public Text tx;
    public float health = 100f;
    public float dam = 20f;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "PlayerBull")
        {
            health -= dam;
            Destroy(collision.collider.gameObject);
        }
        if(collision .collider .tag == "box")
        {
            health -= dam;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            SceneManager.LoadScene("score");
        }
        

        tx.text = "<3 : " + health.ToString();
        
    }
}
