using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 movementValue;
    private float lookValue;
    public float speed;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

	private void OnMove(InputValue value)
	{
        movementValue = value.Get<Vector2>()*speed;
	}
    private void OnLook(InputValue value) {
        lookValue = value.Get<Vector2>().x*rotationSpeed;
    }
	// Update is called once per frame
	void Update()
    {
        transform.Translate(
            movementValue.x * Time.deltaTime,
            0,
            movementValue.y * Time.deltaTime);

        transform.Rotate(0, lookValue * Time.deltaTime, 0);
	}
}
