using System;
using TMPro;
using UnityEngine;

public class DistanceCheck : MonoBehaviour
{
    public Transform target;
    public Transform marble;
    public TextMeshProUGUI timetext; 

    // Update is called once per frame
    void Update()
    {
        Vector3 distance = target.position - marble.position;
        double dis = Math.Round(distance.magnitude);
        if (distance.magnitude > 0.8) {
            timetext.text = "Distance: "+ Math.Round(distance.magnitude, 1).ToString() + " meter";
        } else {
            timetext.text = "You win!";
        }
    }
}
