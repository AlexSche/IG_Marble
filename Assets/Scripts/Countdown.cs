using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    private int timer = 60;
    private TextMeshProUGUI timetext; 

    void Start(){
        timetext = GetComponent<TextMeshProUGUI>();
        this.StartCoroutine("BeginCountdown");
    }

    IEnumerator BeginCountdown() {
        if (timer > 1) {
            timer -= 1;
            Debug.Log(timer);
            timetext.text = timer.ToString();
            yield return new WaitForSeconds(1);
            this.StartCoroutine("BeginCountdown");
        } else {
            timetext.text = "Time is up!";
            this.StopAllCoroutines();
        }
    }
}