using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMainMenuBtn : MonoBehaviour
{
    public void OpenSettigns()
    {
        SceneManager.LoadScene("Settings");
    }
    public void QuitGame()
    {
        Debug.Log("Quit Gamme");
        Application.Quit();
    }
}
