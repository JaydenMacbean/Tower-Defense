   
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//beweegt langs een pad

public class PathFollower : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float arrivalThreshold;
    [SerializeField] private int StageHealth;
    public Path path;
    public WayPoint currentWaypoint;
    private void Start()
    {
        SetupPath();
    }
    private void Update()
    {
        transform.LookAt(currentWaypoint.GetPosition());
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        float distanceToWaypoint = Vector3.Distance(transform.position, currentWaypoint.GetPosition());
        if (distanceToWaypoint <= arrivalThreshold)
        {
            if (currentWaypoint == path.GetPathEnd())
            {
                PathComplete();
            }
            else
            {
                 
                currentWaypoint = path.GetNextWaypoint(currentWaypoint);
                

            }
        }
    }
    void SetupPath()
    {
        path = FindObjectOfType<Path>();
        currentWaypoint = path.GetPathStart();
    }
    void PathComplete()
    {
        Destroy(gameObject);
        StageHealth--;
        if (StageHealth == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
