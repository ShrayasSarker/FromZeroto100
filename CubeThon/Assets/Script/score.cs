using TMPro;
using UnityEngine;

public class score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;
    public int baseScore = -4481;// Example: Base score
    void Update()
    {
    int score = baseScore + Mathf.FloorToInt(player.position.z); // Example: Score based on x-axis
    scoreText.text = "Score: " + score.ToString();
}
}
