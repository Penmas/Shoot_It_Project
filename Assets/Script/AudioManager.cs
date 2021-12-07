using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioMixer mixer;
    public AudioSource BgSound;
    public AudioClip bg;
    public static AudioManager instance;
    public Slider AudioSlider;
    public float AudioSliderValue;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject);
        }

    }

    private void Update()
    {
        AudioSliderValue = AudioSlider.value;
        if (GameManager.GameState > 0)
        {
            BgSound.Stop();
        }
    }

    public void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        BgSoundPlay(bg);
    }
    
    public void BgSoundVolume(float val)
    {
        mixer.SetFloat("BgSound", Mathf.Log10(val)*30);
        mixer.SetFloat("SFX", Mathf.Log10(val) * 30);
        
    }


    public void SFXPlay(string sfxName, AudioClip clip)
    {
        GameObject go = new GameObject(sfxName + "Sound");
        AudioSource audiosource = go.AddComponent<AudioSource>();
        audiosource.outputAudioMixerGroup = mixer.FindMatchingGroups("SFX")[0];
        audiosource.clip = clip;
        audiosource.Play();

        Destroy(go, clip.length);
    }


    public void BgSoundPlay(AudioClip clip)
    {
        BgSound.outputAudioMixerGroup = mixer.FindMatchingGroups("BgSound")[0];
        BgSound.clip = clip;
        BgSound.loop = true;
        BgSound.volume = 0.7f;
        BgSound.Play();
    }
}
