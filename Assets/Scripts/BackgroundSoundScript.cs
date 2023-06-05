using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSoundScript : MonoBehaviour
{
    public AudioSource backgroundSoundSource;

    public void stopSound()
    {
		backgroundSoundSource.Stop();
    }
}
