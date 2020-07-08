using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMovement : MonoBehaviour
{
    public Transform start;
    public Transform end;
    
    private void FixedUpdate()
    {
        if (PlayerControler.foward == true)
        {
            transform.position += Vector3.back * SpeedControll.RoadSpeed;
        }
        else
        {
            transform.position += Vector3.left * SpeedControll.RoadSpeed;
        }
    }
}
