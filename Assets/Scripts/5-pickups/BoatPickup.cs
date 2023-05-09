using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatPickup : MonoBehaviour
{
    // Start is called before the first frame update
    AllowedTiles allowed_tiles_script;
    [SerializeField] GameObject allowedTile;
    void Start()
    {
        allowed_tiles_script = allowedTile.GetComponent<AllowedTiles>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        // if (other.tag == "Player")
        // {
            allowed_tiles_script.addWater();
            
            
            var destroyComponent = other.GetComponent<DestroyOnTrigger2D>();
            Destroy(gameObject);
        // }
    } 
    
}
