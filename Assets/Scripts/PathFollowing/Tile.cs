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



    [SerializeField] private bool IsBuildable;
    [SerializeField] private bool IsSpawnPoint;
    [SerializeField] private bool IsWayPoint;
    [SerializeField] private bool IsPath;





    private void Update()
    {
        GetIsBuildable();
        GetIsWayPoint();
        GetIsPath();
        GetIsSpawnpoint();
    }

    public bool GetIsBuildable()
    {

        return IsBuildable;
    }
    public bool GetIsWayPoint()
    {

        return IsWayPoint;
    }
    public bool GetIsPath()
    {

        return IsPath;
    }
    public bool GetIsSpawnpoint()
    {

        return IsSpawnPoint;
    }



}
