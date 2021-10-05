using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController controller;

    public float speed = 6f;


    // Update is called once per frame
    void Update()
    {
        float horizantal = Input.GetAxisRaw("Horizantal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizantal, 0f, vertical).normalized;
        if (direction.magnitude >= 0.1f)
        {
            controller.Move(direction * speed * Time.deltaTime);
        }

        
    }
}
