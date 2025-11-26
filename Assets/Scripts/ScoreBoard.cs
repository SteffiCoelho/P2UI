using UnityEngine;
using TMPro; 
public class ScoreBoard : MonoBehaviour
{
    public TMP_Text scoreText; 
    private int score = 0;
    
    void Start()
    {
        UpdateScore(); 
    }
    
    public void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }
   
    public void OnButtonClick()
    {
        score += 10; 
        UpdateScore(); 
    }
}