using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 2.0f;


    private CharacterController characterController;

    public Vector2 moveVector = Vector2.zero;

    // Start is called before the first frame update
    void Awake()
    {
        characterController = this.GetComponent<CharacterController>();

        Actions.MoveEvent += UpdateMoveVector;
    }  

    private void UpdateMoveVector(Vector2 InputVector)
    {
        moveVector = InputVector;
    }
 

    private void Update()
    {
        HandlePlayerMovement(moveVector);
    }


    void HandlePlayerMovement(Vector2 moveVector)
    {
        characterController.Move(moveVector * moveSpeed * Time.deltaTime);
    }



    void OnDisable()
    {
        Actions.MoveEvent -= UpdateMoveVector;
    }
}
