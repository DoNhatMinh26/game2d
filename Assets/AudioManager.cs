using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource MusicAudioSource;
    public AudioSource FNAudioSource;
    public AudioClip MusicClip;
    public AudioClip coinClip;
    public AudioClip WinClip;
    public AudioClip BackgroundClip;
    void Start()
    {
        MusicAudioSource.clip= MusicClip;
        MusicAudioSource.Play();
    }
    public void PlayFSX(AudioClip sfxClip)
    {
        FNAudioSource.clip= sfxClip;
        FNAudioSource.PlayOneShot(sfxClip);
    }

   
}
