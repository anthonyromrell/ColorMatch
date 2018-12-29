using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundFX : MonoBehaviour
{
    public AudioSource source;

    void PlaySound(AudioClip clip)
    {
        source.PlayOneShot(clip);
    }
}