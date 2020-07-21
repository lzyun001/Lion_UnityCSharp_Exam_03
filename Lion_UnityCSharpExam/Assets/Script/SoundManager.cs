
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public Runner runner;
    public AudioClip soundeffect;
    AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
        runner.onFinish += SoundEffect;
    }

    private void SoundEffect()
    {
        source.PlayOneShot(soundeffect,1f);
    }
}
