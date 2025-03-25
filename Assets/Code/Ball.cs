using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // ตรวจสอบแรงที่กระทำบนลูกบอล
        Vector3 gravityForce = Physics.gravity * rb.mass;
        rb.AddForce(gravityForce);
    }
}
