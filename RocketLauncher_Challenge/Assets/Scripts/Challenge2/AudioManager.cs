using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : Singleton<AudioManager>
{
    private AudioSource source;

    protected override void Awake()
    {
        base.Awake();
        source = gameObject.AddComponent<AudioSource>();

        source.volume = 0.3f;
    }

    public void Play(AudioClip clip)
    {
        source.clip = clip;
        source.Play();
        source.loop = true;
    }
}
