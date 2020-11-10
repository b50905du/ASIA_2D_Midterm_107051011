using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void startgame()
    {
        print("開始遊戲");
        SceneManager.LoadScene("關卡一");
    }
    public void quitgame()
    {
        print("結束遊戲");
        Application.Quit();
    }
}
