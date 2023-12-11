using System.Collections;
using UnityEngine;

public class respaw : MonoBehaviour
{
    public float initialX = 0.0f;
    public float initialY = 0.0f;
    public float initialZ = 0.0f;
    private Vector3 checkpointPos;

    // Tempo de cooldown para o respawn
    private float respawnCooldown = 1;

    private void Start()
    {
        checkpointPos = new Vector3(initialX, initialY, initialZ);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("canva"))
        {
            UpdateCheckpoint(collision.transform.position);
        }
        else if (collision.CompareTag("obstacle"))
        {
            Die();
        }
    }

    void Die()
    {
        Respawn();
    }

    void UpdateCheckpoint(Vector3 pos)
    {
        checkpointPos = pos;
    }

    void Respawn()
    {
        StartCoroutine(RespawnWithCooldown());
    }

    IEnumerator RespawnWithCooldown()
    {
        // Aguarde o tempo de cooldown
        yield return new WaitForSeconds(respawnCooldown);

        // Define a posição de respawn como a posição do último checkpoint
        transform.position = checkpointPos;
    }
}
