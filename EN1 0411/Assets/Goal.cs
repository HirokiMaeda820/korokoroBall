using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject clearText;
    public GameObject NextBotton;
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ÉSÅ[ÉãÅI");

        clearText.SetActive(true);
        NextBotton.SetActive(true);
        audioSource.Play();
    }
}
