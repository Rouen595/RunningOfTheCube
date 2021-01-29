using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 1200f;
    public float sidewaysForce = 500f;
    

    // Start is called before the first frame update
    void Start()
    {
        //rb.AddForce(0, 200, 500);
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //var d = (Input.GetAxis("Mouse ScrollWheel"));
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }


        // added below to increase or decrease speed based on player input

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardForce * 2.5f * Time.deltaTime);
        }



        if (rb.position. y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }


    }
}
