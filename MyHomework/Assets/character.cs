using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
	public Transform cameraTransform;
	// Transform값은 카메라 움직임에 따라 달라지므로,해당 값을 카메라에 넘겨주기 위한
	// CameraTransform 변수 선언

	public CharacterController characterController;
	// CharacterController에 3D 오브젝트를 적용하기 위한 characterController 변수 선언

	public float moveSpeed = 200f;
	// 이동 속도
	public float jumpSpeed = 30f;
	// 점프 속도
	public float gravity = -20f;
	// 중력
	public float yVelocity = 0;
	// Y축 움직임

	void Start()
	{

	}

	void Update()
	{
		float h = Input.GetAxis("Horizontal");
		// h 변수에 키보드의 가로값 (좌, 우) 을 읽어온 결과를 넘긴다.
		// ◀, ▶, A, D 키

		float v = Input.GetAxis("Vertical");
		// v 변수에 키보드의 세로값 (상, 하) 을 읽어온 결과를 넘긴다.
		// ▲, ▼, W, S 키

		Vector3 moveDirection = new Vector3(h, 0, v);
		// (x축, y축, z축 = h 변수, 0, v 변수) 에서 읽어온 값을 Vector3으로 만듦
		// 해당 값을 Vector3 형식의 moveDirection 값으로 넘긴다.

		moveDirection = cameraTransform.TransformDirection(moveDirection);
		// moveDirection 값은 카메라 위치

		moveDirection *= moveSpeed;
		// 최종적인 moveDirection 값은 moveDirection * moveSpeed 값을 서로 곱한 것.



		characterController.Move(moveDirection * Time.deltaTime);
		// 최종적으로 characterController의 움직임은 방향 * Time.deltaTime 값
	}
}