using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HintText : MonoBehaviour
{
    public Text titleText;

    private void Start()
    {
        StartCoroutine(BlinkText());
    }

    private void Update()
    {
        OpenScene();
    }

    private void OpenScene()
    {
        if(Input.anyKeyDown)
        {
            SceneManager.LoadScene("Maze");
        }
    }

    public IEnumerator BlinkText()
    {
        while(true)
        {
            titleText.text = "";
            yield return new WaitForSeconds(1.0f);
            titleText.text = "按下任何鍵開始";
            yield return new WaitForSeconds(1.0f);
        }
    }
}
