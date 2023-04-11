using System.Collections.Generic;
using UnityEngine;

class LongPathMover : MonoBehaviour
{
    [SerializeField] List<Transform> points;                // listát a tömbbõl
    [SerializeField] float speed;

    int currentIndex = 0;

    void Update()
    {
        if (points.Count == 0) return;

        if (currentIndex >= points.Count)     
            currentIndex = 0;
        List<Transform> randomlist = new List<Transform>();

        while (points.Count > 0) 
        {
            int randomIndex = Random.Range(0, points.Count);
            randomlist.Add(points[randomIndex]);
            points.RemoveAt(randomIndex);
  
        }
        points = randomlist;

        Transform target = points[currentIndex];

        if (target == null)
        {
            currentIndex++;
            target = points[currentIndex];
            Debug.LogError("Missing Path Point!");
        }
        if (target == null) return;

        Vector3 selfPos = transform.position;
        Vector3 targetPos = target.position;

        // towards megspórol 10 sornyi kódot
        transform.position = Vector3.MoveTowards(selfPos, targetPos, speed * Time.deltaTime);       // a move towards nem fog túlugrani, pontosan a célhoz érkezik, ezért fontos

        if (transform.position == targetPos)
        {
            currentIndex++;
        }
    }
}

