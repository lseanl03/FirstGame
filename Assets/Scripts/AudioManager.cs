using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class AudioManager : MonoBehaviour
{
    public Sounds[] sounds;
    public static AudioManager instance;
    private void Awake()
    {
        foreach(Sounds s in sounds)
        {
            s.soucre = gameObject.AddComponent<AudioSource>();
            s.soucre.volume = s.volume;
            s.soucre.clip = s.clip;
            s.soucre.loop = s.loop;
            s.soucre.playOnAwake = s.playOnAwake;
        }
    }
    private void Start()
    {
        
    }
    public void PlaySounds(string name)
    {
        Sounds s = Array.Find(sounds, sounds => sounds.name == name);
        s.soucre.Play();
        if (s == null)
        {
            return;
        }
    }
    
}
