using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public CharacterController control;
    public float speed = 6f;


        
    

   
    void Update()
    {
    float horizantal = Input.GetAxisRaw("Horizantal");
    float vertical = Input.GetAxisRaw("Vertical");
    Vector3 direction = new Vector3(horizantal, 0f, vertical).normalized;

    if(direction.magnitude >= 0.1f)
    {
        control.Move(direction * speed * Time.deltaTime);
    }
        
    }
}
