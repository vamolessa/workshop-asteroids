using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfeitoAsteroideDestruido : MonoBehaviour
{
    public ParticleSystem meuParticleSystem;
    public AudioSource meuAudioSource;
    public float delayAutoDestruir = 1.0f;

    void Start()
    {
    	meuParticleSystem.Play(false);
        meuAudioSource.Play();
        Destroy(gameObject, delayAutoDestruir);
    }
}
