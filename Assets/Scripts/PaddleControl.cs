using UnityEngine;

public class PaddleControl : MonoBehaviour
{
    public float MovementSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() 
    {
        Debug.Log("Hi! Hi I'm Start!");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 changeInPos = new Vector3(0,0,0);

        //Move the paddle left and right with A and D

        if(Input.GetKey(KeyCode.A))
        {
            Debug.Log("Pressed A, Moving Left");
            changeInPos = changeInPos + new Vector3(-MovementSpeed, 0,0);
        }

        if(Input.GetKey(KeyCode.D))
        {
            Debug.Log("Pressed D, Moving Right");
            changeInPos = changeInPos + new Vector3(MovementSpeed, 0,0);
        }

        transform.position = transform.position + changeInPos;
    }
}
