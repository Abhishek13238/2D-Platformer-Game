using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public static CoinManager Instance;
    [Header("Coin UI")]
    public TextMeshProUGUI levelCoinText;
    [Header("CoinVariable")]
    public int coins = 0;
    public int totalCoins = 0;
    int coinValue = 1;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            totalCoins = PlayerPrefs.GetInt("TotalCoin", 0);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddCoin()
    {
        coins += coinValue;
        levelCoinText.text = coins.ToString();
    }
    public void AddTotalCoin()
    {
        totalCoins += coins;
        PlayerPrefs.SetInt("TotalCoin", totalCoins);
    }
    public void ResetCoin()
    {
        coins = 0;
        levelCoinText.text = coins.ToString();
    }
}
