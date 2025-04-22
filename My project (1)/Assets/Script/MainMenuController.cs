using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public void OnStartButton()
    {
        Debug.Log("Start button pressed");
        GameManager.Instance.LoadScene("Game");
    }

    public void OnQuitButton()
    {
        Application.Quit();
        Debug.Log("Quit called");
    }
}