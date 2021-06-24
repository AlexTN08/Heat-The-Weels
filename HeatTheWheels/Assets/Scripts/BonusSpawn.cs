using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusSpawn : MonoBehaviour
{
    public Transform spawnPoint;
    private float spawnerTime = 6f;

    // Start is called before the first frame update
    void Start()
    {
            InvokeRepeating("SpawnObject", spawnerTime, spawnerTime);
    }

    // Update is called once per frame
    void Update()
    {
        
        

    }

    void SpawnObject()
    {
        Instantiate(this.gameObject, spawnPoint.position , spawnPoint.rotation);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 7)
        {
            Destroy(gameObject);
        }
    }
}
