using UnityEngine;

public class ThrowBall : MonoBehaviour
{
    public float zSpeed = -0.0f;
    public float xAxis = -0.0f;
    public float spin = 0.0f;
    bool spaceBarIsPressed = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Controls ball rotation 
        if (Input.GetKeyDown(KeyCode.A))
        {
            xAxis -= 5;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            xAxis += 5;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            zSpeed -= 50;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            zSpeed += 50;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            spin -= 5;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            spin += 5;
        }

        if (Input.GetKeyDown("space"))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.AddForce(new Vector3(xAxis, 0.0f, zSpeed));
            rb.AddTorque(new Vector3(spin, 0.0f, 0.0f));
        }
    }     
}
