using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControl : MonoBehaviour
{
    [SerializeField] List<AudioSource> audioSources;
    const string musicPath = "Music";

    private void Start()
    {
        if (PlayerPrefs.HasKey(musicPath))
        {
            foreach (AudioSource AS in audioSources)
            {
                AS.volume = PlayerPrefs.GetFloat(musicPath);

            }
        }
        else
        {
            foreach (AudioSource AS in audioSources)
            {
                AS.volume = 0.5f;

            }
        }
    }

    public void MusicActive(bool isActive)
    {
        if (isActive)
        {
            foreach (AudioSource AS in audioSources)
            {
                AS.volume = 1;
                PlayerPrefs.SetFloat(musicPath, 1);
            }
        }
        else
        {
            foreach (AudioSource AS in audioSources)
            {
                AS.volume = 0;
                PlayerPrefs.SetFloat(musicPath, 0);
            }
        }
    }

}
