using UnityEngine;

public class MarbleControl : MonoBehaviour
{
    private Rigidbody rb;
    private HealthSystem healthSystem;
    private Countdown countdown;
    public float speed = 18.0f;

    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        healthSystem = gameObject.GetComponent<HealthSystem>();
        countdown = gameObject.GetComponent<Countdown>();
    }

    void FixedUpdate()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        input = input.normalized;
        rb.AddForce(input*speed);
        inBoundCheck();
    }

    void inBoundCheck() 
    {
        if (this.transform.position.y < (-5)) {
            // lose health if marble is falling
            this.healthSystem.LoseHealth();
            restart();
        }
    }

    void restart() {
        Vector3 restartPosition = new Vector3(0,1,0);
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        this.transform.position = restartPosition;
        countdown.restart();
    }
}
