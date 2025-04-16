using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int totalCoins = 5;
    private int coinsCollected = 0;
    private float timeRemaining = 120f;
    private bool gameEnded = false;
    private float timeAtWin;

    // UI Elements
    public TMP_Text timerText;
    public TMP_Text coinText;
    public GameObject resultCanvas;
    public TMP_Text resultTitleText;
    public TMP_Text resultMessageText;
    public TMP_Text notificationText;
    public GameObject gameUICanvas;

    // Player and Camera Controller References
    public GameObject player;
    private ThirdPersonController playerController;
    public GameObject cameraControllerObject;
    private CameraController cameraController;

    // Audio
    public AudioSource backgroundMusic; 
    public AudioClip winSound;          
    public AudioClip loseSound;        
    private AudioSource sfxSource;      // For win/lose sounds

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    void Start()
    {
        resultCanvas.SetActive(false);
        gameUICanvas.SetActive(true);
        notificationText.text = "";
        UpdateCoinUI();

        playerController = player.GetComponent<ThirdPersonController>();
        if (playerController == null) Debug.LogError("ThirdPersonController not found!");

        cameraController = cameraControllerObject.GetComponent<CameraController>();
        if (cameraController == null) Debug.LogError("CameraController not found!");

        // Set up SFX AudioSource
        sfxSource = gameObject.AddComponent<AudioSource>();
    }

    void Update()
    {
        if (!gameEnded)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimerUI();
            if (timeRemaining <= 0)
                EndGame(false);
        }
    }

    public void CollectCoin()
    {
        coinsCollected++;
        UpdateCoinUI();
        if (coinsCollected == totalCoins)
            ShowNotification("All coins collected! Head to the Gate!");
    }
    public void LoseCoin()
    {
        if (coinsCollected > 0) 
        {
            coinsCollected--;
            UpdateCoinUI();
            Debug.Log("Lost a coin! Coins remaining: " + coinsCollected);
        }
    }

    public void ReachGate()
    {
        if (coinsCollected == totalCoins)
        {
            timeAtWin = 120f - timeRemaining;
            EndGame(true);
        }
        else
        {
            ShowNotification("Not all coins collected yet! Coins: " + coinsCollected + "/" + totalCoins);
        }
    }

    void EndGame(bool won)
    {
        gameEnded = true;
        gameUICanvas.SetActive(false);
        resultCanvas.SetActive(true);
        
        if (playerController != null) playerController.SetControllerEnabled(false);
        if (cameraController != null) cameraController.SetCameraEnabled(false);

        // Play win or lose sound
        if (won)
        {
            sfxSource.PlayOneShot(winSound);
            resultMessageText.text = "You Win! You cleared the floor in " + timeAtWin.ToString("F2") + "s";
        }
        else
        {
            sfxSource.PlayOneShot(loseSound);
            resultMessageText.text = "You Lose! Try better next time";
        }
        resultTitleText.text = "Result";

        // Optional: Lower background music volume during result
        if (backgroundMusic != null) backgroundMusic.volume = 0.3f;
    }

    void UpdateTimerUI()
    {
        timerText.text = "Time: " + Mathf.Max(0, timeRemaining).ToString("F2") + "s";
    }

    void UpdateCoinUI()
    {
        coinText.text = "Coins: " + coinsCollected + "/" + totalCoins;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    private void ShowNotification(string message)
    {
        notificationText.text = message;
        Invoke("ClearNotification", 2.5f);
    }

    private void ClearNotification()
    {
        notificationText.text = "";
    }
}