using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : Dying
{
    public int stockCheck;

    public GameObject[] units;

    private void Start()
    {
        stockCheck = units.Length;
    }

    private void Update()
    {
         
    }

    public override void Death()
    {
        Destroy(gameObject);
        stockCheck--;
    }
}
