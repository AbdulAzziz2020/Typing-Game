using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public string name;
    [Range(.1f, 1f)] public float volume = .1f;
    [Range(.3f, 3f)] public float pitch = 1f;
    public AudioClip clip;
}

public class AudioManager : SingletonPersistant<AudioManager>
{
    public override void Awake()
    {
        base.Awake();
    }

    public Sound[] bgm;
    public AudioSource sourceBGM;

    public Sound[] sfx;
    public AudioSource sourceSFX;

    public void Start()
    {
        PlayBGM("BGM");
    }

    public void PlayBGM(string name)
    {
        Sound b = Array.Find(bgm, x => x.name == name);
        
        if(b == null) Debug.Log("Not Found BGM");

        sourceBGM.clip = b.clip;
        sourceBGM.volume = b.volume;
        sourceBGM.pitch = b.pitch;

        sourceBGM.Play();
    }

    public void PlaySFX(string name)
    {
        Sound s = Array.Find(sfx, x => x.name == name);
        
        if(s == null) Debug.Log("SFX Not Found!");

        sourceSFX.clip = s.clip;
        sourceSFX.volume = s.volume;
        sourceSFX.pitch = s.pitch;
        
        sourceSFX.PlayOneShot(sourceSFX.clip);
    }
}
