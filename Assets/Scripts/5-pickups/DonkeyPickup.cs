using System.Collections;
using System.Threading.Tasks;
using UnityEngine;

public class DonkeyPickup : MonoBehaviour
{

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
            
            allowed_tiles_script.addMountain();
            
            
            var destroyComponent = other.GetComponent<DestroyOnTrigger2D>();
            Destroy(gameObject);
        // }
    } 
    

    
}
