using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator AuthorsAnimator;
    public void Play()
    {
        SceneManager.LoadScene(0);
    }

    public void ChangeAuthorsStatus()
    {
        AuthorsAnimator.SetBool("IsOpen", !AuthorsAnimator.GetBool("IsOpen"));
    }

    public void Exit()
    {
        Application.Quit();
    }
}
