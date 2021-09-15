﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSoundController : MonoBehaviour
{
    public AudioClip jump;
    public AudioClip scoreHighlight;

    private AudioSource audioPlayer;

    // Start is called before the first frame update
    private void Start()
    {
        audioPlayer = GetComponent<AudioSource>();
    }

    public void PlayScoreHighlight()
    {
        audioPlayer.PlayOneShot(scoreHighlight);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayJump()
    {
        audioPlayer.PlayOneShot(jump);
    }
}
