using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(UnitInRangeCheck))]
public class Tower : Unit
{
    private UnitInRangeCheck unitInRangeChecker;

   

    private void Start()
    {
        unitInRangeChecker = GetComponent<UnitInRangeCheck>();
    }

    private void Update()
    {
        Unit unit = unitInRangeChecker.GetFirstEnemyInRange();
        if(unit!=null) 
        {
            print(unit.name);
            unit.TakeDamage(1);
        }
    }
}
