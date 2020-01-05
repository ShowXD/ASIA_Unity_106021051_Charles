using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GetBox : MonoBehaviour
{
    [Header("寶箱數量介面")]
    public Text textCount;

    [Header("結束介面")]
    public GameObject winTip;

    [Header("道具數量")]
    public static int propCount;
    public int propTotal = 10;

    [Header("終點門口")]
    public GameObject finalLeftDoor;
    public GameObject finalRightDoor;

    public static bool finish = false;

    private void Start()
    {
        finish = false;
        propCount = 0;
    }

    private void Update()
    {
        OpenDoor();
    }
    
    /// <summary>
    /// 碰撞偵測
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Box")
        {
            Destroy(collision.gameObject);
            propCount++;
            textCount.text = "剩餘寶箱數量:" + propCount + "/10";


            if(propCount == propTotal)
            {
                finish = true;
                winTip.SetActive(true);
            }
        }
        else if(collision.gameObject.tag == "Dead")
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene("GameOver");
        }
    }

    private void OpenDoor()
    {
        if(finish)
        {
            finalLeftDoor.transform.localPosition = Vector3.MoveTowards(finalLeftDoor.transform.localPosition, new Vector3(15, -1.9067e-05f, -108), 5 * Time.deltaTime);
            finalRightDoor.transform.localPosition = Vector3.MoveTowards(finalLeftDoor.transform.localPosition, new Vector3(3, -1.8584e-05f, -107), 5 * Time.deltaTime);
        }
        
    }
}
