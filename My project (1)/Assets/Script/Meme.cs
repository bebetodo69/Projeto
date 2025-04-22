using UnityEngine;

public class SplashController : MonoBehaviour
{
    private void Start()
    {
        Invoke("GoToMainMenu", 2f);
    }

    void GoToMainMenu()
    {
        GameManager.Instance.LoadScene("MainMenu");
    }
}