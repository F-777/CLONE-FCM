using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    public Text scoreText;
    public Text timerText;

    private int playerScore = 0;
    private int opponentScore = 0;
    private float matchTime = 300f; // 5 menit (dalam detik)

    private void Update()
    {
        UpdateTimer();
    }

    private void UpdateTimer()
    {
        matchTime -= Time.deltaTime;

        int minutes = Mathf.FloorToInt(matchTime / 60f);
        int seconds = Mathf.FloorToInt(matchTime % 60);

        timerText.text = $"{minutes:00}:{seconds:00}";

        if (matchTime <= 0)
        {
            EndMatch();
        }
    }

    public void UpdateScore(bool isPlayerGoal)
    {
        if (isPlayerGoal)
        {
            playerScore++;
        }
        else
        {
            opponentScore++;
        }

        scoreText.text = $"{playerScore} - {opponentScore}";
    }

    private void EndMatch()
    {
        // Logika akhir pertandingan
        Debug.Log("Match Over!");
        Time.timeScale = 0; // Pause game
    }
}
public class UpgradeManager : MonoBehaviour
{
    public PlayerStats player;

    public void UpgradeSpeed()
    {
        player.UpgradeSpeed(1);
    }

    public void UpgradeStrength()
    {
        player.UpgradeStrength(1);
    }

    public void UpgradeAccuracy()
    {
        player.UpgradeAccuracy(1);
    }
}
