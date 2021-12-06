using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecificRouteMovement : MonoBehaviour
{

    [SerializeField] GameObject civ;
    [SerializeField] List<Transform> waypoints;
    [SerializeField] Transform point;
    [SerializeField] float timeCreateCiv;
    [SerializeField] float speed;
    [SerializeField] Cone cone;
    Vector2 tempVec;
    private int waypointIndex = 0;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = waypoints[waypointIndex].transform.position;
        tempVec = new Vector2();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    // Move the enemy according a specific path.
    private void Move()
    {
        if (waypointIndex <= waypoints.Count - 1)
        {
            // The next target position wanted
            var targetPosition = waypoints[waypointIndex].transform.position;

            // Movment speed
            var movementThisFrame = speed * Time.deltaTime;

            // Update new position by 'MoveTowards'
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, movementThisFrame);
            tempVec = targetPosition - transform.position;
            cone.SetDir(tempVec);



            if (transform.position == targetPosition)
            {
                waypointIndex++;
            }


        }
        else
        {
            waypointIndex = 0;
        }


    }
}
