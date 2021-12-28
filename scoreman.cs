using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreman : MonoBehaviour
{
    public Text tx;
    public float score = 0f;
    
    // Start is called before the first frame update
    public void plusScore()
    {
        score = score + 10f;
    }
    public void Update()
    {
        tx.text = "Score:" + score.ToString();
        PlayerPrefs.SetFloat("score", score);
    }

    
}
