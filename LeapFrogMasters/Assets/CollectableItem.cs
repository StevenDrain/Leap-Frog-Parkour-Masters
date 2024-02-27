using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItem : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] string itemName;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            Managers.Inventory.AddItem(itemName);
        Destroy(this.gameObject);
        }
        if(other.CompareTag("Player2")){
            Managers.Inventory.AddItem(itemName);
            Destroy(this.gameObject);
        }
        
    }
}
