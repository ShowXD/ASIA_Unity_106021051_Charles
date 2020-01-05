using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayControl : MonoBehaviour
{
    [Header("動畫控制器選擇")]
    public Animator animator;

    private void Update()
    {
        //人物奔跑
        animator.SetBool("running", Input.GetKey(KeyCode.W)
            || Input.GetKey(KeyCode.A)
            || Input.GetKey(KeyCode.S)
            || Input.GetKey(KeyCode.D));
    }
}
