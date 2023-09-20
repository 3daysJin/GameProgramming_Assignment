using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public GameObject prefab;
    public float startTime;
    public float endTime;
    public float spawnRate;
    public int areaRange;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn",startTime,spawnRate);
        Invoke("CancelInvoke", endTime);
    }
    Vector3 Return_RandomPosition(){
        Vector3 originPosition = this.transform.position;
        float randomLocX = Random.Range((areaRange/2)*-1,areaRange/2);
        float randomLocZ = Random.Range((areaRange/2)*-1,areaRange/2);
        Vector3 randomPosition = new Vector3(randomLocX,0f,randomLocZ);
        Vector3 spawnPosition =originPosition + randomPosition;
        return spawnPosition;
    }
    void Spawn()
    {
        Vector3 newPosition = Return_RandomPosition();
        Instantiate(prefab, newPosition, transform.rotation);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
