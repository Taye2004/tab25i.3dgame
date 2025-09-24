using UnityEngine;

public class GameRespawn : MonoBehaviour
{
    [Header("Respawn Settings")]
    public Vector3 respawnPosition = new Vector3(111, 25, -7); // Default respawn point

    void Update()
    {
        if (transform.position.y <= 2)
        {
            Respawn();
        }
    }

    void Respawn()
    {
        // Optionally reset velocity if Rigidbody is used
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }

        // Move player to respawn position
        transform.position = respawnPosition;
    }
}
