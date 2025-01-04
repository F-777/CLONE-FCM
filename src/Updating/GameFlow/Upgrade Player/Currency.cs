public class CurrencySystem : MonoBehaviour
{
    public int currency = 100;

    public bool SpendCurrency(int amount)
    {
        if (currency >= amount)
        {
            currency -= amount;
            Debug.Log($"Menghabiskan {amount} poin. Sisa: {currency}");
            return true;
        }
        else
        {
            Debug.Log("Poin tidak cukup!");
            return false;
        }
    }
}

public CurrencySystem currencySystem;

public void UpgradeSpeed()
{
    if (currencySystem.SpendCurrency(10))
    {
        player.UpgradeSpeed(1);
    }
}
public class CurrencySystem : MonoBehaviour
{
    public int currency = 100;

    public bool SpendCurrency(int amount)
    {
        if (currency >= amount)
        {
            currency -= amount;
            Debug.Log($"Menghabiskan {amount} poin. Sisa: {currency}");
            return true;
        }
        else
        {
            Debug.Log("Poin tidak cukup!");
            return false;
        }
    }
}
public CurrencySystem currencySystem;

public void UpgradeSpeed()
{
    if (currencySystem.SpendCurrency(10))
    {
        player.UpgradeSpeed(1);
    }
}
