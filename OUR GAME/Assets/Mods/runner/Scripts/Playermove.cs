using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 dir;
    [SerializeField] private int speed;
    private int lineToMove = 1;
    public float lineDistance = 4;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    private void Update()
    {
        if(SwipeController.swipeRight)
        {
            if (lineToMove < 2)
            {
                lineToMove++;
            }
        }
        if(SwipeController.swipeLeft)
        {
            if(lineToMove>0)
            {
                lineToMove--;
            }
        }
        Vector3 targetaPosition = transform.position.z * transform.forward + transform.position.y * transform.up;
        if(lineToMove==0)
        {
            targetaPosition += Vector3.left * lineDistance;
        }
        else if (lineToMove==2)
        {
            targetaPosition += Vector3.right * lineDistance;
        }

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        dir.z = speed;
        controller.Move(dir * Time.fixedDeltaTime);
    }

}
