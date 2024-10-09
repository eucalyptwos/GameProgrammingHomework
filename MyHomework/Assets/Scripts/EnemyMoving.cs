using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoving : MonoBehaviour
{
    [SerializeField] float moveRate;
    [SerializeField] float speed;
	Vector3 moveVec;
	// Start is called before the first frame update
	void Start()
    {
		InvokeRepeating("Rotate", 0, moveRate);
	}
	private void Rotate()
	{
		moveVec = new  Vector3(Random.Range(-1, 1), Random.Range(-1, 1), 0);
	}

	// Update is called once per frame
	void Update()
    {
		var dir = Vector3.down;
		gameObject.transform.Translate(moveVec * speed *Time.deltaTime);
	}
}
