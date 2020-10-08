using UnityEngine.UI; 
using UnityEngine;

public class Score : MonoBehaviour
{
	public Transform player; 
	public Text scoreTxt; 
	public int totalScore = 0;
	public string displayTotalScore;

    void Update()
    {
    	totalScore++;
    	displayTotalScore = totalScore.ToString("0");
    	scoreTxt.text = displayTotalScore;     
    }
}
