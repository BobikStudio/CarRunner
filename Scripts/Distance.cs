using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{
    private float distance;
    [SerializeField] Text distanceDisplay;
    private void FixedUpdate()
    {
        distance += Time.deltaTime * SpeedControll.RoadSpeed;
        
        distanceDisplay.text = "Distance: " + Mathf.Round(distance * 100f) / 100f + " km.";
    }
}
