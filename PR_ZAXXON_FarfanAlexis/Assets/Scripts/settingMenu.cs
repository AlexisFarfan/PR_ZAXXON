using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class settingMenu : MonoBehaviour
{

    public AudioMixer audioMixer; 

    public void setVolume (float volume)
    {
         audioMixer.SetFloat("volume", volume);
    }
}
