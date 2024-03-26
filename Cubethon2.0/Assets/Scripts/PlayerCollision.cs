using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public GameBehavior gameManager;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameBehavior>().EndGame();
        }
    }
}
