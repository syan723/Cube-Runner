using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;
public class Score : MonoBehaviour
{
    public TMP_Text text;
    int myScore= 1;
    public TMP_Text finalScoreText;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = myScore.ToString();
        finalScoreText.text = "Score : "+myScore.ToString();
    }

    public void AddScore(int score)
    {
        myScore = myScore + score;
    }
}
