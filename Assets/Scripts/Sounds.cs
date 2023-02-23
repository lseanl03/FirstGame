using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Sounds
{
    public string name;
    [Range(0f,1f)]
    public float volume;
    public bool loop;
    public bool playOnAwake;
    [HideInInspector]
    public AudioSource soucre;
    public AudioClip clip;
}