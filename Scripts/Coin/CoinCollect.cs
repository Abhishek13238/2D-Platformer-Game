using UnityEngine;
using TMPro;

public class CoinCollect : MonoBehaviour
{
    public AudioSource coinCollectSound;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            CoinManager.Instance.AddCoin();
            coinCollectSound.PlayOneShot(coinCollectSound.clip);
            Destroy(gameObject);
        }
    }
}