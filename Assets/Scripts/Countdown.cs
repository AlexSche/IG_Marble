using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    private int timer = 60;
    private TextMeshProUGUI timetext; 
    private HealthSystem healthSystem;

    void Start(){
        timetext = GetComponent<TextMeshProUGUI>();
        this.StartCoroutine("BeginCountdown");
    }

    IEnumerator BeginCountdown() {
        if (timer > 1) {
            timer -= 1;
            timetext.text = timer.ToString();
            yield return new WaitForSeconds(1);
            this.StartCoroutine("BeginCountdown");
        } else {
            timetext.text = "Time is up!";
            healthSystem.LoseHealth();
            this.StopAllCoroutines();
        }
    }
}
