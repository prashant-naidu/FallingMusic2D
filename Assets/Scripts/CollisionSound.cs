using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class CollisionSound : MonoBehaviour
{
    public AudioClip Sound;

    private AudioSource m_AudioSource;

    //Play the music
    private bool m_Played = false;

    private void Start()
    {
        //Fetch the AudioSource from the GameObject
        m_AudioSource = GetComponent<AudioSource>();
        m_AudioSource.clip = Sound;
    }

    private void OnParticleCollision(GameObject other)
    {
        if (other.name != "BgRain")
        {
            m_AudioSource.Play();
        }
    }
}
