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
