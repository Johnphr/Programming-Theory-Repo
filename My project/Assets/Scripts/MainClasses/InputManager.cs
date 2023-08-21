using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private float horizontalInput;
    [SerializeField] GameObject[] projectilePrefab;
    private int curPrefab = 0;
    private bool burst = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckMovement();
        HandleAction();
    }
    // Call the respective player action depending on inputs
    void HandleAction()
    {
        // Change value of burst with Left Shift key
        burst = (Input.GetKey(KeyCode.LeftShift)) ? true : false;
        // Shoot regular projectile if space if pressed and burst if Shift is held
        if (Input.GetKeyDown(KeyCode.Space))
        {
            curPrefab = (burst) ? 1 : 0;
            PlayerController.Shoot(projectilePrefab[curPrefab], burst);
        }
        // Move the player if the input is not 0
        if (horizontalInput != 0)
        {
            PlayerController.MovePlayer(horizontalInput);
        }
    }
    void CheckMovement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }
}
