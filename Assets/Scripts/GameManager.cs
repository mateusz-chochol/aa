using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public Animator animator;
    public static bool isQuitRequested = false;

    public void LoadFirstLevel() {

        animator.SetBool("HasStarted", true);
    }

    public void LoadWinAnimation() {

        animator.SetBool("GameWin", true);
    }

    public void LoadStartAgainAnimation() {

        animator.SetBool("StartAgain", true);
    }

    public void LoadNextLevel() {
        
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            PinController.pinCount = 0;
    }

    public void GameOver() {

        animator.SetBool("GameOver", true);
    }

	public void RestartTheLevel() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        PinController.pinCount = 0;
    }

    public void LoadMenu() {

        SceneManager.LoadScene(0);
    }

    public void QuitGame() {

        Application.Quit();
    }
}
