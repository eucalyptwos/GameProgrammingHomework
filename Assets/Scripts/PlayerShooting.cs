using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject prefab;
    public GameObject ShootPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject clone;

		if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            clone = Instantiate(prefab);
            clone.transform.position = ShootPoint.transform.position;
            clone.transform.rotation = ShootPoint.transform.rotation;
        }
        
	}   
}
