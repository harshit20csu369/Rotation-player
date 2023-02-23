using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Waypoints : MonoBehaviour
{
    public List<Transform> waypoint;
    private NavMeshAgent player;
    int index;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<NavMeshAgent>();
        player.SetDestination(waypoint[0].position);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Vector3.Distance(transform.position, waypoint[index].position) <= 2f)
        {
            if(index <waypoint.Count-1)
            {
                index++;
            }
            else if(index==waypoint.Count-1)
            {
                index = 0;
            }
            player.SetDestination(waypoint[index].position);
        }
        
    }
}
