using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class WorldGenerator : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private RoadMovement roadFoward;
    [SerializeField] private RoadMovement turnRignt;
    [SerializeField] private RoadMovement roadRight;   
    [SerializeField] private RoadMovement turnFoward;


    [SerializeField] private RoadMovement firstRoad;

    private List<RoadMovement> spawnedPrefabs = new List<RoadMovement>();


    private void Start()
    {
        spawnedPrefabs.Add(firstRoad);
    }

    private void Update()
    {
        if (player.position.z > spawnedPrefabs[spawnedPrefabs.Count - 1].end.position.z - 100)
        {
            SpawnRoad();
        }
    }

    private void SpawnRoad ()
    {

        int number = Random.Range(0, 4);

        for (int i = 0; i <= number; i++)
        {          
                RoadMovement Roadfoward = Instantiate(roadFoward);
                Roadfoward.transform.position = spawnedPrefabs[spawnedPrefabs.Count - 1].end.position - Roadfoward.start.localPosition;
                spawnedPrefabs.Add(Roadfoward);
        }
               
            RoadMovement TurnRight = Instantiate(turnRignt);
            TurnRight.transform.position = spawnedPrefabs[spawnedPrefabs.Count - 1].end.position - TurnRight.start.localPosition;
            spawnedPrefabs.Add(TurnRight);

        number = Random.Range(1, 4);

        for (int i = 0; i <= number; i++)
        {
            if (i == 1)
            {
                RoadMovement RoadRight1 = Instantiate(roadRight);
                RoadRight1.transform.position = spawnedPrefabs[spawnedPrefabs.Count - 1].end.position + new Vector3(8, -1, 0);
                RoadRight1.transform.rotation = spawnedPrefabs[spawnedPrefabs.Count - 1].end.rotation;
                spawnedPrefabs.Add(RoadRight1);
            }
            if (i == 2)
            {
                RoadMovement RoadRight2 = Instantiate(roadRight);
                RoadRight2.transform.position = spawnedPrefabs[spawnedPrefabs.Count - 2].end.position + new Vector3(24, -1, 0);
                RoadRight2.transform.rotation = spawnedPrefabs[spawnedPrefabs.Count - 2].end.rotation;
                spawnedPrefabs.Add(RoadRight2);
            }
            if (i == 3)
            {
                RoadMovement RoadRight3 = Instantiate(roadRight);
                RoadRight3.transform.position = spawnedPrefabs[spawnedPrefabs.Count - 3].end.position + new Vector3(32, -1, 0);
                RoadRight3.transform.rotation = spawnedPrefabs[spawnedPrefabs.Count - 3].end.rotation;
                spawnedPrefabs.Add(RoadRight3);
            }
            if (i == 4)
            {
                RoadMovement RoadRight4 = Instantiate(roadRight);
                RoadRight4.transform.position = spawnedPrefabs[spawnedPrefabs.Count - 4].end.position + new Vector3(40, -1, 0);
                RoadRight4.transform.rotation = spawnedPrefabs[spawnedPrefabs.Count - 4].end.rotation;
                spawnedPrefabs.Add(RoadRight4);
            }

        }

        RoadMovement TurnFoward = Instantiate(turnFoward);
            TurnFoward.transform.position = spawnedPrefabs[spawnedPrefabs.Count - 1].end.position - TurnFoward.start.localPosition + new Vector3(36, 0, 0);
            spawnedPrefabs.Add(TurnFoward);
          
        if (spawnedPrefabs.Count >= 25)
        {
            Destroy(spawnedPrefabs[0].gameObject);
            spawnedPrefabs.RemoveAt(0);
        }
    }
}
