using UnityEngine;
using System.Collections.Generic;

public class TournamentManager : MonoBehaviour
{
    [System.Serializable]
    public class Team
    {
        public string teamName;
        public int score;
    }

    public List<Team> teams; // Daftar tim
    private int currentMatchIndex = 0;

    public void StartTournament()
    {
        Debug.Log($"Memulai turnamen dengan {teams.Count} tim!");
        PlayNextMatch();
    }

    public void PlayNextMatch()
    {
        if (currentMatchIndex < teams.Count - 1)
        {
            Team team1 = teams[currentMatchIndex];
            Team team2 = teams[currentMatchIndex + 1];

            Debug.Log($"Pertandingan berikutnya: {team1.teamName} vs {team2.teamName}");
            currentMatchIndex += 2;
        }
        else
        {
            Debug.Log("Turnamen selesai! Menentukan pemenang...");
            DetermineWinner();
        }
    }

    private void DetermineWinner()
    {
        Team winner = null;
        int highestScore = 0;

        foreach (Team team in teams)
        {
            if (team.score > highestScore)
            {
                highestScore = team.score;
                winner = team;
            }
        }

        Debug.Log($"Pemenang turnamen adalah {winner.teamName} dengan skor {winner.score}!");
    }
}
