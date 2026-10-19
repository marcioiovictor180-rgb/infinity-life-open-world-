using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class VehicleController : MonoBehaviour
{
    public float acceleration = 12f;
    public float steeringSpeed = 80f;
    public float maxSpeed = 25f;

    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float throttle = Input.GetAxis("Vertical");
        float steering = Input.GetAxis("Horizontal");

        if (rb.linearVelocity.magnitude < maxSpeed)
        {
            rb.AddForce(
                transform.forward * throttle * acceleration,
                ForceMode.Acceleration
            );
        }

        if (rb.linearVelocity.magnitude > 0.5f)
        {
            float turn = steering * steeringSpeed * Time.fixedDeltaTime;
            rb.MoveRotation(rb.rotation * Quaternion.Euler(0f, turn, 0f));
        }
    }
}
