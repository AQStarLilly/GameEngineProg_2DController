using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController characterController;

    public Vector2 moveDirection = new Vector2(0.00f, 1.00f);
    

    // Start is called before the first frame update
    void Start()
    {
        characterController = this.GetComponent<CharacterController>();
    }  

    void HandlePlayerMovement(Vector2 moveDirection)
    {
        characterController.Move(moveDirection * Time.deltaTime);
    }    
}
