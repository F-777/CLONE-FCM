using UnityEngine;

[System.Serializable]
public class PlayerStats
{
    public string playerName;
    public int speed;
    public int strength;
    public int accuracy;

    public void UpgradeSpeed(int amount)
    {
        speed += amount;
        Debug.Log($"{playerName} meningkatkan kecepatan menjadi {speed}");
    }

    public void UpgradeStrength(int amount)
    {
        strength += amount;
        Debug.Log($"{playerName} meningkatkan kekuatan menjadi {strength}");
    }

    public void UpgradeAccuracy(int amount)
    {
        accuracy += amount;
        Debug.Log($"{playerName} meningkatkan akurasi menjadi {accuracy}");
    }
}
