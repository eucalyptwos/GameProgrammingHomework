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
        Instantiate(prefab, transform.position, transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
