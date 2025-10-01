using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseMenu : MonoBehaviour
{

    public void RetryButton()
    {
        SceneManager.LoadScene("MiniGame");
    }

    public void ReturnButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
