using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioSource audioSource;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (GameObject.Find("AudioSource"))
        {
            Destroy(transform.gameObject);
        }
    }


    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
