using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicBullet : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    public void FixedUpdate()
    {
        if (rb.useGravity)
        {
            Vector3 velocity = transform.forward * moveSpeed;
            rb.velocity = velocity;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!rb.useGravity)
        {
            Vector3 targetPosition = transform.position + (transform.forward * moveSpeed * Time.deltaTime);
            transform.position = Vector3.Lerp(transform.position, targetPosition, 1.0f);
        }
    }
}
