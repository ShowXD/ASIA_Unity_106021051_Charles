using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAudio : MonoBehaviour
{
    [Header("開門音效")]
    public AudioSource leftDoorAudio;
    public AudioClip audioClip;

    private bool isPlayed = false;

    // Start is called before the first frame update
    void Start()
    {
        leftDoorAudio = GetComponent<AudioSource>();
        isPlayed = false;
    }

    // Update is called once per frame
    void Update()
    {
        Sound();
    }

    private void Sound()
    {
        if(GetBox.finish && !isPlayed)
        {
            leftDoorAudio.PlayOneShot(audioClip);
            isPlayed = true;
        }
    }
}
