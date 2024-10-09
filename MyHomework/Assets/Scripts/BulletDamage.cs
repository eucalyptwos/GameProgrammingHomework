using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
	public int damage;
	private void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Enemy")
		{
			other.gameObject.GetComponent<Enemy>().hp -= damage;
			if (other.gameObject.GetComponent<Enemy>().hp < 1) Destroy(other.gameObject);
		}
		if (other.gameObject.name != "AP(Clone)")
		{
			Destroy(gameObject);
		}
	}
}
