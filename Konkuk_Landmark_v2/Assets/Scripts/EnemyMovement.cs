using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject targetPosition;
    public float speed;
    bool isMoving = false;
    private Vector3 destination;
    public float actRange;

    // Start is called before the first frame update
    void Start()
    {
    }
    Vector3 Return_RandomDestination(){
        Vector3 originPosition = this.transform.position;
        float randomLocX = Random.Range((actRange/2)*-1,actRange/2);
        float randomLocZ = Random.Range((actRange/2)*-1,actRange/2);
        Vector3 randomPosition = new Vector3(randomLocX,0f,randomLocZ);
        Vector3 destination = originPosition + randomPosition;
        return destination;
    }
    // Update is called once per frame
    void Update()
    {
        if(!isMoving){
            isMoving = true;
            destination = Return_RandomDestination();
            targetPosition.transform.position = destination;
        }else{
            if(transform.position == targetPosition.transform.position){
                isMoving = false;
            }
        }
    }
}
