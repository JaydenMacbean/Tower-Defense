using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitInRangeCheck : MonoBehaviour
{
    [SerializeField] private float _radius;
    [SerializeField] private LayerMask layer;

    public Unit GetFirstEnemyInRange()
    {
        Collider[] cols = Physics.OverlapSphere(transform.position, _radius, layer);
        print(cols.Length);
        if (cols.Length <= 0)
        {
            return null;
        }
        return cols[0].GetComponent<Unit>();
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, _radius);
    }

}
