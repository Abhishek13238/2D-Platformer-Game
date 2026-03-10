using UnityEngine;
using TMPro;
public class FinishLine : MonoBehaviour
{
    public GameObject levelFinish;
    public AudioSource levelComplete;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            levelComplete.Play();
            levelFinish.SetActive(true);
            CoinManager.Instance.AddTotalCoin();
            Time.timeScale = 0f;

        }
    }
}
