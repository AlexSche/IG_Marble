using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame() {
        SceneManager.LoadScene("Playground");
    }

    public void OpenSettings() {

    }

    public void QuitGame() {
        Application.Quit();
    }
}
