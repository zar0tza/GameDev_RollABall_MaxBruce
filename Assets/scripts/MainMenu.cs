using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {

    }

    public void PlayButton()
    {
        SceneManager.LoadScene("MiniGame");
    }
    
    public void ExitButton()
    {

    }
}
