using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyBackgroundAudio : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject); 
    }
}
