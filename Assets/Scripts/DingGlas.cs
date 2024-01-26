
using UnityEngine;

public class DingGlas : MonoBehaviour
{
    public AudioClip dingGlas;
    public AudioSource source;
    void Start() {
        source.playOnAwake = false;
        source.clip = dingGlas;
    }
    private void OnCollisionEnter(Collision Enter) {
        source.Play();
    }
}
