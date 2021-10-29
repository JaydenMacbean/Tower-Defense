using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSelect : MonoBehaviour
{
    
    public Camera cam;

    public GameObject testObject;


    //Changes to this color on enter
    Color tileColor = Color.red;

    //Changes back on exit
    Color tileOriginColor;

    MeshRenderer TileRenderer;

    [SerializeField] private LayerMask placeableTile;

    public bool isTowerPlaceable;

    //Determines whether a tower is placeable on a tile or not

    void Start()
    {
        Debug.Log("start");
        //Connects the variable with the main camera
        cam = Camera.main;

        TileRenderer = GetComponent<MeshRenderer>();

        //Saves the original color so it can be used again
        tileOriginColor = TileRenderer.material.color;

        //unitStocks = 5;

        if (placeableTile == LayerMask.GetMask("PlacementTest"))
        {
            this.isTowerPlaceable = true;
            Debug.Log("Skill issue negated");
        }

        
        if (placeableTile != LayerMask.GetMask("PlacementTest"))
        {
            this.isTowerPlaceable = false;
            Debug.Log("Absolute skill issue, also Becky is een idioot");
        }
        else
        {
           
        }
    }

    
    void Update()
    {
       
    }

    void OnMouseEnter()
    {
        if (this.isTowerPlaceable)
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

        if (this.isTowerPlaceable)
        {
            if (Input.GetMouseButtonDown(0)) 
            {
                Instantiate(testObject, transform.position, Quaternion.identity);
                //unitStocks--;
                Debug.Log(transform.position);
                this.isTowerPlaceable = false;

            }
        }
    }
}
