using UnityEngine;

public class PaddleWithForce : MonoBehaviour
{
    private Rigidbody paddle_rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        paddle_rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 forceToAdd = new Vector3(0,0,0);

        //Move the paddle left and right using A and D by adding a force

        if(Input.GetKey(KeyCode.A))
        {
            Debug.Log("Moving Left");
            forceToAdd = forceToAdd + new Vector3(-10,0,0);
        }
        if(Input.GetKey(KeyCode.D))
        {
            Debug.Log("Moving right");
            forceToAdd = forceToAdd + new Vector3(10,0,0);
        }

         paddle_rb = GetComponent<Rigidbody>();
         paddle_rb.AddForce(forceToAdd);

        }
    
}
