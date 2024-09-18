using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
	public Transform cameraTransform;
	// Transform���� ī�޶� �����ӿ� ���� �޶����Ƿ�,�ش� ���� ī�޶� �Ѱ��ֱ� ����
	// CameraTransform ���� ����

	public CharacterController characterController;
	// CharacterController�� 3D ������Ʈ�� �����ϱ� ���� characterController ���� ����

	public float moveSpeed = 200f;
	// �̵� �ӵ�
	public float jumpSpeed = 30f;
	// ���� �ӵ�
	public float gravity = -20f;
	// �߷�
	public float yVelocity = 0;
	// Y�� ������

	void Start()
	{

	}

	void Update()
	{
		float h = Input.GetAxis("Horizontal");
		// h ������ Ű������ ���ΰ� (��, ��) �� �о�� ����� �ѱ��.
		// ��, ��, A, D Ű

		float v = Input.GetAxis("Vertical");
		// v ������ Ű������ ���ΰ� (��, ��) �� �о�� ����� �ѱ��.
		// ��, ��, W, S Ű

		Vector3 moveDirection = new Vector3(h, 0, v);
		// (x��, y��, z�� = h ����, 0, v ����) ���� �о�� ���� Vector3���� ����
		// �ش� ���� Vector3 ������ moveDirection ������ �ѱ��.

		moveDirection = cameraTransform.TransformDirection(moveDirection);
		// moveDirection ���� ī�޶� ��ġ

		moveDirection *= moveSpeed;
		// �������� moveDirection ���� moveDirection * moveSpeed ���� ���� ���� ��.



		characterController.Move(moveDirection * Time.deltaTime);
		// ���������� characterController�� �������� ���� * Time.deltaTime ��
	}
}