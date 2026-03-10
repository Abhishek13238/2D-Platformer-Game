using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        if (CoinManager.Instance = null)
        {
            CoinManager.Instance.AddTotalCoin();
        }
    }
}
