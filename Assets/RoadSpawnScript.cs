using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : MonoBehaviour
{
    public GameObject roadSegmentPrefab;
    public Transform player;
    public float segmentLength = 6144f;

    private List<GameObject> spawnedSegments = new List<GameObject>();

    void Start()
    {
        SpawnInitialSegments();
    }

    void Update()
    {
        Debug.Log("Update is running!");

        CheckSegmentSpawn();
        CheckSegmentDeletion();
    }

    void SpawnInitialSegments()
    {
        for (int i = 0; i < 3; i++)
        {
            SpawnRoadSegment();
        }
    }

    void SpawnRoadSegment()
    {
        Vector3 spawnPosition = Vector3.zero;

        if (spawnedSegments.Count > 0)
        {
            spawnPosition = spawnedSegments[spawnedSegments.Count - 1].transform.position + new Vector3(0, 0, segmentLength);
        }

        GameObject newSegment = Instantiate(roadSegmentPrefab, spawnPosition, Quaternion.identity);
        spawnedSegments.Add(newSegment);
    }

    void CheckSegmentSpawn()

    {
        Debug.Log("Checking Segment Spawn");

        float distanceToLastSegment = player.position.z - spawnedSegments[spawnedSegments.Count - 1].transform.position.z;

        if (distanceToLastSegment >= segmentLength)
        {
            SpawnRoadSegment();
        }
    }

    void CheckSegmentDeletion()

    {
        Debug.Log("Checking Segment Deletion");

        float distanceToFirstSegment = player.position.z - spawnedSegments[0].transform.position.z;

        if (distanceToFirstSegment >= segmentLength)
        {
            Destroy(spawnedSegments[0]);
            spawnedSegments.RemoveAt(0);
        }
    }
}
