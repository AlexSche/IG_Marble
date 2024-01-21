using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settingsMenu;
    
    void Start() {
        mainMenu.SetActive(true);
        settingsMenu.SetActive(false);
    }
    public void StartGame() {
        SceneManager.LoadScene("Playground");
    }

    public void OpenSettings() {
        mainMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }

    public void CloseSettings() {
        mainMenu.SetActive(true);
        settingsMenu.SetActive(false);
    }

    public void QuitGame() {
        Application.Quit();
    }
}
