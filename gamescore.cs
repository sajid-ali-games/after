using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamescore : MonoBehaviour
{
    public float score;
    public Text tx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score = PlayerPrefs.GetFloat("score");
        tx.text =":" + score.ToString();

    }

    public void restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
