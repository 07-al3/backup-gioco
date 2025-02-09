using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonsActionsManager : MonoBehaviour
{
    [SerializeField] private GameObject volumeScreen;
    [SerializeField] private GameObject creditsButton;
    [SerializeField] private GameObject main;

    public void newGame()
    {
        PlayerPrefs.SetInt("livello1", 0);
        PlayerPrefs.SetInt("livello2", 0);
        PlayerPrefs.SetInt("livello3", 0);
        PlayerPrefs.SetInt("livello4", 0);
        
        PlayerPrefs.Save();

        SceneManager.LoadScene(1);
    }

    public void quitGame()
    {
        Application.Quit();

        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

    public void volume()
    {
        volumeScreen.SetActive(!volumeScreen.activeInHierarchy);
    }

    public void credits()
    {
        creditsButton.SetActive(!creditsButton.activeInHierarchy);
        main.SetActive(!main.activeInHierarchy);
    }
}