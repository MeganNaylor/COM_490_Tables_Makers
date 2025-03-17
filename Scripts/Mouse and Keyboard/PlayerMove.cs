using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public CharacterController controller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            controller.Move(Vector3.forward);
        }

        if (Input.GetKey(KeyCode.S))
        {
            controller.Move(Vector3.back);
        }
        if (Input.GetKey(KeyCode.A))
        {
            controller.Move(Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            controller.Move(Vector3.right);
        }
    }
}
