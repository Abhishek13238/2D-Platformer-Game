using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.position + offset;
        if (player.position.y <= -1f)
        {
            this.enabled = false;
        }
    }
}
