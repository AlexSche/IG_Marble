using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BreakGlas : MonoBehaviour
{
    public GameObject brokenGlas;
    public AudioClip breakGlas;
    public AudioSource source;
    void Start() {
        source.playOnAwake = false;
        source.clip = breakGlas;
    }
    private void OnCollisionEnter(Collision Enter) {
        source.Play();
        brokenGlas.gameObject.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
