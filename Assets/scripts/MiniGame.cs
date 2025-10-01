using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGame : MonoBehaviour
{
    public void ReturnMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
