
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManger : MonoBehaviour
{
    public void Startgame()
    {
        print("開始遊戲");
        SceneManager.LoadScene("關卡1");
    }

    public void Quitgame()
    {
        print("離開遊戲");
        Application.Quit();
    }

}
