using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSelect : MonoBehaviour
{
    
    public Camera cam;

    public GameObject testObject;

    public GameObject placeableTile;

    public static GameObject[] testObjects;

    //Changes to this color on enter
    Color tileColor = Color.red;

    //Changes back on exit
    Color tileOriginColor;

    MeshRenderer TileRenderer;

    //Determines whether a tower is placeable on a tile or not
    public static bool isTowerPlaceable;

    //public static int unitStocks;

    private void Awake()
    {
        placeableTile = GameObject.FindWithTag("PlacementTest");
    }
    void Start()
    {
        Debug.Log("start");
        //Connects the variable with the main camera
        cam = Camera.main;

        TileRenderer = GetComponent<MeshRenderer>();

        //Saves the original color so it can be used again
        tileOriginColor = TileRenderer.material.color;

        //unitStocks = 5;
        
        if(placeableTile == GameObject.FindWithTag("PlacementTest"))
        {
            isTowerPlaceable = true;
        }
    }

    
    void Update()
    {
 
    }

    void OnMouseEnter()
    {
        if(isTowerPlaceable == true)
        {
            Debug.Log("Mouse has entered the chat.");
            TileRenderer.material.color = tileColor;
        }
         
    }
    void OnMouseExit()
    {
        Debug.Log("Mouse is away from the GameObject.");
        TileRenderer.material.color = tileOriginColor;
    }

    public void OnMouseOver()
    {
        
        if (isTowerPlaceable == true)
        {
            if (Input.GetMouseButtonDown(0)) 
            {
                Instantiate(testObject, transform.position, Quaternion.identity);
                //unitStocks--;
                Debug.Log(transform.position);

            }
        }
    }
}
