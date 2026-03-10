using UnityEngine;

public class InGameMenu : MonoBehaviour
{
    public GameObject canvas;
    public AudioSource menuOpenSound;
    public void Menu()
    {
        canvas.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Exit()
    {
        canvas.SetActive(false);
        Time.timeScale = 1f;
    }

    public void SoundOnClick()
    {
        menuOpenSound.Play();
    }
}
