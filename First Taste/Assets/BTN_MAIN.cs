using UnityEngine;
using UnityEngine.SceneManagement;

public class BTN_MAIN : MonoBehaviour
{
    public void OpenSettings()
    {
        SceneManager.LoadScene("Settings");       
    }
}
