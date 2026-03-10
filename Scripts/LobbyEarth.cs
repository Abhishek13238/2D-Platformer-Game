using UnityEngine;

public class LobbyEarth : MonoBehaviour
{
    public float rotateSpeed = -10f;   // minus (-) = clockwise

    void Update()
    {
        transform.Rotate(0f, 0f, rotateSpeed * Time.deltaTime);
    }
}

