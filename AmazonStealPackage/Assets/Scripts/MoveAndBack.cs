using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndBack : MonoBehaviour
{
    Vector2 startingPos;
    [SerializeField] Vector2 placeToWalk;
    [SerializeField] float speed;
    [SerializeField] float waitingTime;
    [SerializeField] Cone cone;
    Vector2 coneDir;
    bool hasReached= false;
    bool switchedGlance = false;
    Vector2 tempVec;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        tempVec = new Vector2(transform.position.x, transform.position.y);
        startingPos = transform.position;
        Vector2 coneDir = placeToWalk - new Vector2(transform.position.x, transform.position.y);
        cone.SetDir(coneDir);
        



    }
    public void SetPlaceToWalk(Vector2 toWalk)
    {
        placeToWalk = toWalk;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasReached) {
            tempVec.x = transform.position.x;
            tempVec.y = transform.position.y;
            if (tempVec != placeToWalk) {
                transform.position = Vector2.MoveTowards(transform.position, placeToWalk, speed * Time.deltaTime);
                
                }
            else
            {
                hasReached = true;
                timer = 0;
            }

        }
        else
        {
            timer += Time.deltaTime;
            if (timer > waitingTime)
            {
                if (!switchedGlance)
                {
                    
                    cone.NewGaze(coneDir);
                    switchedGlance = true;
                }
                else
                {
                    tempVec.x = transform.position.x;
                    tempVec.y = transform.position.y;
                    if (tempVec != startingPos)
                    {
                        transform.position = Vector2.MoveTowards(transform.position, startingPos, speed * Time.deltaTime);
                    }

                    else
                    {
                        Destroy(gameObject);
                    }
                }
            }
        }


    }
}
