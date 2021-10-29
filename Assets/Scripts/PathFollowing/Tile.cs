using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public Material PathMaterial;
    public Material BuildMaterial;
    public Material WayPointMaterial;
    public Material SpawnMaterial;
    public Material DefautMaterial;



    [SerializeField] private bool isBuildable;
    [SerializeField] private bool isSpawnPoint;
    [SerializeField] private bool isWayPoint;
    [SerializeField] private bool isPath;





    private void Update()
    {
        GetIsBuildable();
        GetIsWayPoint();
        GetIsPath();
        GetIsSpawnpoint();
    }

    public bool GetIsBuildable()
    {

        return isBuildable;
    }
    public bool GetIsWayPoint()
    {

        return isWayPoint;
    }
    public bool GetIsPath()
    {

        return isPath;
    }
    public bool GetIsSpawnpoint()
    {

        return isSpawnPoint;
    }



}
