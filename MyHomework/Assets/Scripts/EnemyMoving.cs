using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoving : MonoBehaviour
{
    [SerializeField] float moveRate;
    [SerializeField] float speed;
	
	// Start is called before the first frame update
	void Start()
    {
		InvokeRepeating("Rotate", 0, moveRate);
	}
	private void Rotate()
	{
		transform.Rotate(0, 0, Random.Range(-60, 60));
	}

	// Update is called once per frame
	void Update()
    {
		var dir = Vector3.down;
		gameObject.transform.Translate(dir * speed * 3*Time.deltaTime);
	}
}
