
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameBehavior gameBehavior;
    void OnTriggerEnter()
    {
        gameBehavior.CompleteLevel();
    }
}
