using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionsSon : MonoBehaviour
{

    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private Slider SliderMusique;
   


    public void UpdateMusique()
    {

        float volume = SliderMusique.value;
        audioMixer.SetFloat("VolumeMusique", volume);
    }
   

}