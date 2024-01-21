using System.Collections;
using TMPro;
using UnityEngine;

public class Countdown : MonoBehaviour
{
    private int timer = 60;
    public TextMeshProUGUI timeText; 
    public TextMeshProUGUI notificationText;
    public HealthSystem healthSystem;

    void Start(){
        this.StartCoroutine("Timer");
    }

    public void stopTimer() {
        this.StopCoroutine("Timer");
    }

    public void restart() {
        timer = 60;
    }

    IEnumerator Timer() {
        if (timer > 0) {
            timer -= 1;
            timeText.text = timer.ToString();
            yield return new WaitForSeconds(1);
            this.StartCoroutine("Timer");
        } else {
            notificationText.text = "Time is up!";
            healthSystem.LoseHealth();
            this.StopAllCoroutines(); 
        }
    }
}
