using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;// Position offset relative to player

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
