using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioSettings : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider musicVolumeSlider;
    public Slider sfxVolumeSlider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (PlayerPrefs.HasKey("AudioVolume"));
        {
        musicVolumeSlider.value = PlayerPrefs.GetFloat("AudioVolume");
        mixer.SetFloat("AudioVolume", musicVolumeSlider.value);
        }

        if (PlayerPrefs.HasKey("SFXVolume"));
        {
            sfxVolumeSlider.value = PlayerPrefs.GetFloat("SFXVolume");
            mixer.SetFloat("SFXVolume", sfxVolumeSlider.value);
        }
    }
    public void SetAudioVolume(float volume)
    {
        mixer.SetFloat("AudioVolume", volume);
        PlayerPrefs.SetFloat("AudioVolume", volume);
        PlayerPrefs.Save();
    }

     public void SetSFXVolume(float volume)
    {
        mixer.SetFloat("SFXVolume", volume);
        PlayerPrefs.SetFloat("SFXVolume", volume);
        PlayerPrefs.Save();
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
