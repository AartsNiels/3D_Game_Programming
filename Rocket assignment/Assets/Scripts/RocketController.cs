using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    public int points = 0;
    [SerializeField] float thrusterForce = 10f;
    [SerializeField] float tiltingForce = 10f;

    bool thrust = false;

    Rigidbody rb;

    private void Awake ()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update ()
    {
        float tilt = Input.GetAxis("Horizontal");
        thrust = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Space);

        if (!Mathf.Approximately(tilt, 0f))
        { 
            rb.freezeRotation = true;
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + (new Vector3(0f, 0f, (tilt * tiltingForce * Time.deltaTime))));
        }
        rb.freezeRotation = false;
    }

    private void FixedUpdate()

    {
        if(thrust)
        {
            rb.AddRelativeForce(Vector3.up * thrusterForce * Time.deltaTime);
        }
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Score : " + points);
    }
}