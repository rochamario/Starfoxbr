using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float targetDistance = 10.0f;
    public float enemySpeed = 0.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
         GameObject player = GameObject.FindGameObjectWithTag("Player");
                if ((player.transform.position - transform.position).magnitude <= targetDistance)
                {
                    Vector3 newPosition = transform.position;
                    newPosition.z = player.transform.position.z + targetDistance;
                    transform.position = newPosition;
                }
                else
                {
                    transform.position += transform.forward * enemySpeed * Time.deltaTime;
                }
    }
}


/* GameObject player = GameObject.FindGameObjectWithTag("Player");
        if ((player.transform.position - transform.position).magnitude <= targetDistance)
        {
            Vector3 newPosition = transform.position;
            newPosition.z = player.transform.position.z + targetDistance;
            transform.position = newPosition;
        }
        else
        {
            transform.position += transform.forward * enemySpeed * Time.deltaTime;
        }*/

/*        GameObject player = GameObject.FindGameObjectWithTag("Player");
    if (Vector3.Project(player.transform.position - transform.position, player.transform.forward).magnitude <= targetDistance)
    {
        transform.position += Vector3.Project((player.transform.position - transform.position).normalized * targetDistance, player.transform.forward) - Vector3.Project(transform.position, player.transform.forward);

    }
    else
    {
        transform.position += transform.forward * enemySpeed * Time.deltaTime;
    }
*/