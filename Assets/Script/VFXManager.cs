using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject vfxAudioSource;
    public GameObject vfxAudioSourceSwitch;

    public void PlayVFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(vfxAudioSource, spawnPosition, Quaternion.identity);


    }
    public void PlayVFXSwitch(Vector3 spawnPosition)
    {
        GameObject.Instantiate(vfxAudioSourceSwitch, spawnPosition, Quaternion.identity);
    }
}
