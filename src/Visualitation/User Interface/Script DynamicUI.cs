using UnityEngine;
using TMPro;

public class DynamicUI : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text notificationText;

    public TMP_Text matchInfoText;
    public TMP_Text winnerText;

public void UpdateMatchInfo(string team1, string team2)
{
    matchInfoText.text = $"{team1} vs {team2}";
}

public void ShowWinner(string winnerName)
{
    winnerText.text = $"Pemenang: {winnerName}";
}


    private int team1Score = 0;
    private int team2Score = 0;

    public void UpdateScore(int team1, int team2)
    {
        team1Score = team1;
        team2Score = team2;
        scoreText.text = $"Team 1: {team1Score} - Team 2: {team2Score}";
    }

    public void ShowNotification(string message, float duration)
    {
        StartCoroutine(DisplayNotification(message, duration));
    }

    private IEnumerator DisplayNotification(string message, float duration)
    {
        notificationText.text = message;
        notificationText.enabled = true;
        yield return new WaitForSeconds(duration);
        notificationText.enabled = false;
    }
}
public void UpdateMatchInfo(string team1, string team2)
{
    matchInfoText.text = $"{team1} vs {team2}";
}

public void ShowWinner(string winnerName)
{
    winnerText.text = $"Pemenang: {winnerName}";
}