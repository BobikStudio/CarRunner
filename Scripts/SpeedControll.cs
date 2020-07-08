using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedControll : MonoBehaviour
{
    public static float RoadSpeed;
    [SerializeField] private float GameSpeed;

    private void Start()
    {
        RoadSpeed = GameSpeed;
    }
}
