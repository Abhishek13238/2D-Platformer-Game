using UnityEngine;
using TMPro;

public class TotalCoinDisplay : MonoBehaviour
{
    public TextMeshProUGUI totalCoinText;

    void Start()
    {
        if (totalCoinText != null)
        {
            int saveTotalCoin = PlayerPrefs.GetInt("TotalCoin", 0);
            totalCoinText.text = saveTotalCoin.ToString();
        }
    }
}
