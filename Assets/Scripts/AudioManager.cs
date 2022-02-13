using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioClip DeadClip;
    [SerializeField] AudioClip JumpClip;
    [SerializeField] Player player;

    void Start()
    {
        player.DeadAction += PlayDeadClip;
        player.JumpAction += PlayJumpClip;
    }

   void PlayDeadClip()
   {
        player.gameObject.GetComponent<AudioSource>().PlayOneShot(DeadClip);
        Debug.Log(1);
   }

    void PlayJumpClip()
    {
        player.gameObject.GetComponent<AudioSource>().PlayOneShot(JumpClip);
    }
}
