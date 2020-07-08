using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomObject : MonoBehaviour
{

    [SerializeField] private GameObject[] traps;

    void Start()
    {
        int number = Random.Range(0, traps.Length);

        traps[number].SetActive(true);
    }


}
