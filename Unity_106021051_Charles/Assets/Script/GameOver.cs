using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [Header("背景音樂")]
    public AudioSource bgmSource;
    // public AudioClip audioClip;

    // Start is called before the first frame update
    void Start()
    {
        bgmSource = GetComponent<AudioSource>();
        bgmSource.loop = true;
        bgmSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (GetBox.finish)
        {
            // Esc離開
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }

            // R重來
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("Title");
            }
        }
    }
}
