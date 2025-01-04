using Firebase.Database;
using UnityEngine;

public class LeaderboardManager : MonoBehaviour
{
    private DatabaseReference database;

    private void Start()
    {
        database = FirebaseDatabase.DefaultInstance.RootReference;
    }

    public void SubmitScore(string playerName, int score)
    {
        string key = database.Child("leaderboard").Push().Key;
        LeaderboardEntry entry = new LeaderboardEntry(playerName, score);
        string json = JsonUtility.ToJson(entry);

        database.Child("leaderboard").Child(key).SetRawJsonValueAsync(json);
    }

    public void FetchLeaderboard()
    {
        database.Child("leaderboard").OrderByChild("score").GetValueAsync().ContinueWith(task =>
        {
            if (task.IsCompleted)
            {
                DataSnapshot snapshot = task.Result;
                foreach (DataSnapshot child in snapshot.Children)
                {
                    Debug.Log($"{child.Child("playerName").Value}: {child.Child("score").Value}");
                }
            }
        });
    }
}

[System.Serializable]
public class LeaderboardEntry
{
    public string playerName;
    public int score;

    public LeaderboardEntry(string playerName, int score)
    {
        this.playerName = playerName;
        this.score = score;
    }
}
