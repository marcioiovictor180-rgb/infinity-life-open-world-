using UnityEngine;

public class PlayerWallet : MonoBehaviour
{
    public int startingMoney = 1000;

    public int Money { get; private set; }

    void Awake()
    {
        Money = startingMoney;
    }

    public bool SpendMoney(int amount)
    {
        if (amount <= 0 || Money < amount)
            return false;

        Money -= amount;
        return true;
    }

    public void EarnMoney(int amount)
    {
        if (amount > 0)
            Money += amount;
    }
}
