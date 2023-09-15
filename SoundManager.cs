using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip PickUpSound, HitSound;
    static AudioSource AudioSrc;
    // Start is called before the first frame update
    void Start()
    {
        PickUpSound = Resources.Load<AudioClip>("PickUp");
        HitSound = Resources.Load<AudioClip>("Hit");

        AudioSrc = GetComponent<AudioSource>();

        
    }
    void Update()
    {

    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "PickUp":
                AudioSrc.PlayOneShot(PickUpSound);
                break;
            case "Hit":
                AudioSrc.PlayOneShot(HitSound);
                break;
        }
    }
}