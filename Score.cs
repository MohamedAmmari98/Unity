using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // SCORE.
    public Text myScoreText;
    public int scoreNum;

    // Start is called before the first frame update
    void Start()
    {
        // FOR SCORE.
        scoreNum = 0;
        myScoreText.text = "" + scoreNum;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

         void OnTriggerEnter2D(Collider2D coin){
        if(coin.gameObject.tag == "coin"){
           scoreNum++;
           myScoreText.text = "" + scoreNum;
    }
    }
}
