using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scoring : MonoBehaviour
{

    static private Scoring S;

    [Header("Inscribed")]
    // public TK.TextMeshProUGUI
    public TMP_Text scoreText;

    [Header("Dynamic")]
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        S = this;

        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateGUI()
    {
        scoreText.text = "Score: " + score;
    }

    static public void UpdateScore()
    {
        S.score++;
    }

}
