using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public AudioClip coinCollectSound; // Assign in Inspector
    private AudioSource coinSource;    // For coin sound

    void Start()
    {
        coinSource = gameObject.AddComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            GameManager.Instance.CollectCoin();
            if (coinCollectSound != null) coinSource.PlayOneShot(coinCollectSound);
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Gate"))
        {
            GameManager.Instance.ReachGate();
        }
    }
}