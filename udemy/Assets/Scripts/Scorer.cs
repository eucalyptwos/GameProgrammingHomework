using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Scorer : MonoBehaviour
{
	private int hits = 0;
	private void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag != "Hit")
		{
			hits++;
			Debug.Log("You`ve bumped into a thing this many times : " + hits);
		}
	}
}