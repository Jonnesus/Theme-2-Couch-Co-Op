using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreCounter;
    public int score = 0;

    private void Update()
    {
        scoreCounter.text = "Score: " + score.ToString();
    }
}