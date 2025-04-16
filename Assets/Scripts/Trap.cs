using UnityEngine;

public class Trap : MonoBehaviour
{
    private bool hasTriggered = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasTriggered)
        {
            hasTriggered = true; 
            GameManager.Instance.LoseCoin(); 
            Debug.Log("Player hit a trap and lost a coin!");
            Destroy(gameObject);
        }
    }
}