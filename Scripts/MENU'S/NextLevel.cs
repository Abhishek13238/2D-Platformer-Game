using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class NextLevel : MonoBehaviour
{
    public AudioSource buttonSound;

    public void Next()
    {
        buttonSound.Play();
        CoinManager.Instance.ResetCoin();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1;
    }

}
