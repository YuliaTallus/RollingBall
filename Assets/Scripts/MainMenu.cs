using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator AuthorsAnimator;
    public void Play()
    {
        SceneManager.LoadScene("Level");
    }

    public void Authors()
    {
        AuthorsAnimator.SetBool("IsOpen", !AuthorsAnimator.GetBool("IsOpen"));
    }

    public void Exit()
    {
        Application.Quit();
    }
}
