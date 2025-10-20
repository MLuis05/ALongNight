using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenScripts : MonoBehaviour
{
    public static void ChangeScene(string nameScene =  "") {
        if (nameScene != " ") {
            SceneManager.LoadScene(nameScene);
        }
    }

    public static void ReloadScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public static void ExitScene() {
        Application.Quit();
    }
}
