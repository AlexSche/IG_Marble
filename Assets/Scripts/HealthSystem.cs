using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] Image[] healthimages;
    private int health;
    
    void Start() {
        health = healthimages.Length;
    }

    public void LoseHealth() {
        if (healthimages.Any()) {
            var last = healthimages.Last();
            Destroy(last);
            health -= 1;
            // Restart (respawn marble) 
        }
        if (health == 0) {
            // GameOver
        }
    }
}
