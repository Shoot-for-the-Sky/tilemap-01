using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.InputSystem;
using System;



public class TileChanger : MonoBehaviour
{
    // public Tile Grass;
    private Vector3Int pos;
    public Tilemap tilemap;

    public TileBase from_tile;

    public TileBase to_tile;

    protected Boolean enable;


    // [SerializeField] protected InputAction changeAction = new InputAction(type: InputActionType.Button);

    private void Start()
    {
        enable = false;
    }

    public void enablePickaxe()
    {
        enable = true;
    }

    private void Update()
    {
        // bool ans = changeAction.WasPressedThisFrame();
        // if(changeAction.WasPressedThisFrame())
        // {
        //     Debug.Log("sdas");    
        // }
        if (Input.GetKeyDown(KeyCode.Space) && enable)
        {
            pos = tilemap.WorldToCell(transform.position+transform.forward*100);
            TileBase currentTile = tilemap.GetTile(pos);
            if(from_tile == currentTile)
            {
                tilemap.SetTile(pos, to_tile);
            }
            
        }

    }
}
