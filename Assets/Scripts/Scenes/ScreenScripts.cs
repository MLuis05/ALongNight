using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenScripts : MonoBehaviour
{
    public void ChangeScene(string nameScene) {
        SceneManager.LoadScene(nameScene);
    }

    public void ReloadScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ExitGame() {
        Application.Quit();
    }
}
