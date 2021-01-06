  
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : Singleton<SoundManager>
{
    private AudioSource playerAudioSource;
    public AudioSource PlayerAudioSource
    {
        get
        {
            if(playerAudioSource==null)
            {
                playerAudioSource=GetComponent<AudioSource>();
            }
            return playerAudioSource;
        }
    }
    
    private void Start() {
        PlayerAudioSource.clip=ThemeSound;
    }
    
    public AudioClip ScoreUpSound;
    public AudioClip LooseHealthSound;
    public AudioClip ThemeSound;
    public AudioClip HealUpSound;
    public AudioClip GameOverSound;
    
    



}
  