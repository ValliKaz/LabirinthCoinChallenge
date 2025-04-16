using UnityEngine;

public class CoinSpin : MonoBehaviour
{
    public float rotationSpeed = 90f; // Adjustable in Inspector

    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}