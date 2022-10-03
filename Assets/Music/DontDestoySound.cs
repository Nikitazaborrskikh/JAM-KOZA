using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestoySound : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    private void Awake()
    {
        DontDestroyOnLoad(_audioSource);
    }
}
