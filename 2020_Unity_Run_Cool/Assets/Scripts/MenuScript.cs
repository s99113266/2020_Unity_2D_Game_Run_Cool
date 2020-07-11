using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuScript : MonoBehaviour
{
    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void ExitGame()
    {
        Application.Quit();
    }

    /// <summary>
    /// 切換場景
    /// </summary>
    public void LoadScene()
    {
        SceneManager.LoadScene("RunCoolGame");
    }


    /// <summary>
    /// 延長呼叫方法
    /// </summary>
    /// <param name="MothodName">方法名稱</param>
    public void DelayMothod(string MothodName)
    {
        Invoke(MothodName, 0.8f);
    }
}
