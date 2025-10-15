using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    public ScoreManager scoremanager;
    public TextMeshProUGUI scoretext;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = "Score: " + scoremanager.currentScore;
    }
}
