using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public Object prefab;
    public float startTime, endTIme, spawnRate;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", startTime, spawnRate);
        Invoke("CancelInvoke", endTIme);
    }
    void Spawn()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-20, 20), 0f, Random.Range(-20, 20));

		Instantiate(prefab, transform.position+ randomPosition, Quaternion.Euler(-90.0f, 0, 0));
	}
    // Update is called once per frame
    void Update()
    {
        
    }
}
