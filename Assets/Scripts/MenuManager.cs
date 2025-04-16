using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject instructionsPanel; 
    public GameObject mainMenuCanvas; 

    void Start()
    {
        instructionsPanel.SetActive(false); 
        mainMenuCanvas.SetActive(true); 
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1); 
    }

    public void ExitGame()
    {
        Application.Quit();
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; 
        #endif
    }

    public void ShowInstructions()
    {
        mainMenuCanvas.SetActive(false); 
        instructionsPanel.SetActive(true); 
    }

    public void HideInstructions()
    {
        instructionsPanel.SetActive(false); 
        mainMenuCanvas.SetActive(true); 
    }
}