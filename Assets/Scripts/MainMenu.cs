using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Animator _authorsAnimator;

    public void Play()
    {
        SceneManager.LoadScene(0);
    }

    public void ChangeAuthorsStatus()
    {
        _authorsAnimator.SetBool("IsOpen", !_authorsAnimator.GetBool("IsOpen"));
    }

    public void Exit()
    {
        Application.Quit();
    }
}
