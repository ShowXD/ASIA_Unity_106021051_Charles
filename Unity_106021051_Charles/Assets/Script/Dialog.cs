using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Dialog : MonoBehaviour
{
    [Header("寶箱數量介面")]
    public Text textCount;

    [Header("計時介面")]
    public Text textTime;

    private float elapsedTime;

    private void Start()
    {
        elapsedTime = 0;
    }

    private void Update()
    {
        GameOver();
        Timing();
    }

    // 遊戲結束操控
    private void GameOver()
    {
        if(GetBox.finish)
        {
            // Esc離開
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }

            // R重來
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("Maze");
            }
        }
    }

    // 倒數計時
    private void Timing()
    {
        elapsedTime = Mathf.FloorToInt(Time.time);
        textTime.text = "經過時間:" + elapsedTime + "秒";
    }
}
