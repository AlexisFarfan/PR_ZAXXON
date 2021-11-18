using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoGameOver : MonoBehaviour
{
    public AudioSource soundGameOver;
    public AudioSource sound;
    public AudioClip soundMenu;

    // Start is called before the first frame update
    public void SoundButton()
    {
        sound.clip = soundMenu;
        sound.enabled = false;
        sound.enabled = true;
    }
}
