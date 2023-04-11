using System.Collections.Generic;
using UnityEngine;

class LongPathMover : MonoBehaviour
{
    [SerializeField] List<Transform> points;                // list�t a t�mbb�l
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

        // towards megsp�rol 10 sornyi k�dot
        transform.position = Vector3.MoveTowards(selfPos, targetPos, speed * Time.deltaTime);       // a move towards nem fog t�lugrani, pontosan a c�lhoz �rkezik, ez�rt fontos

        if (transform.position == targetPos)
        {
            currentIndex++;
        }
    }
}

