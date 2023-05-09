using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickaxePickup : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        // var playerComponent = GameObject.FindWithTag("Player").GetComponent<TileChanger>();
        // playerComponent.enablePickaxe();
        other.GetComponent<TileChanger>().enablePickaxe();

        var destroyComponent = other.GetComponent<DestroyOnTrigger2D>();
        Destroy(gameObject);
        
    } 
}
