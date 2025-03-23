using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    [Header ("AudioSources")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXsource;
    [Header ("AudioClips")]
    public AudioClip background1;
    public AudioClip background2;
    public AudioClip collecting;
    public AudioClip trashbin;

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "Level 1")
        {
            musicSource.clip = background1;
        }
        else if (SceneManager.GetActiveScene().name == "Level 2")
        {
            musicSource.clip = background2;
        }
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXsource.PlayOneShot(clip);
    }
}


