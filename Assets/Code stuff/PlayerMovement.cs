
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    public Rigidbody rb;

    public float fowardForce = 2000f;

    public float sidewaysForce = 500f;

    // Update is called once per frame
    void FixedUpdate ()
    {
   
        rb.AddForce(fowardForce, 0, 0 *Time.deltaTime);


        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
        }

            if (Input.GetKey("a"))
            {
                rb.AddForce(0, 0, -sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);

            }
            if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        }
}
