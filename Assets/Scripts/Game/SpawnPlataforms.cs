using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlataforms : MonoBehaviour
{
    public List<GameObject> platforms = new List<GameObject>();
    public List<Transform> currentPlatforms = new List<Transform>();

    public int offset;

    private Transform player;
    private Transform currentPlatformPoint;

    private int platformsIndex;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        for (int i = 0; i < platforms.Count; i++) {
            Transform p = Instantiate(platforms[i], new Vector3(0, 0, i * 88), transform.rotation).transform;
            currentPlatforms.Add(p);
            offset += 88;
        }

        currentPlatformPoint = currentPlatforms[platformsIndex].GetComponent<Platforms>().point;
    }

    void Update()
    {
        float distance = player.position.z - currentPlatformPoint.position.z;

        if (distance >= 5) {
            Recycle(currentPlatforms[platformsIndex].gameObject);
            platformsIndex++;

            if (platformsIndex >= currentPlatforms.Count) {
                platformsIndex = 0;
            }
            currentPlatformPoint = currentPlatforms[platformsIndex].GetComponent<Platforms>().point;
        }
    }

    public void Recycle(GameObject platform) {
        platform.transform.position = new Vector3(0, 0, offset);
        offset += 88;
    }
}
