public Transform leaderboardPanel;
public GameObject leaderboardRowPrefab;

public void DisplayLeaderboard(List<LeaderboardEntry> entries)
{
    foreach (Transform child in leaderboardPanel)
    {
        Destroy(child.gameObject);
    }

    foreach (LeaderboardEntry entry in entries)
    {
        GameObject row = Instantiate(leaderboardRowPrefab, leaderboardPanel);
        row.transform.Find("PlayerName").GetComponent<Text>().text = entry.playerName;
        row.transform.Find("Score").GetComponent<Text>().text = entry.score.ToString();
    }
}
