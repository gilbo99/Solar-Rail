using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public List<GameObject> items;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Additems(GameObject add)
    {
        items.Add(add);
    }

    public void RemoveItems(GameObject add)
    {
        items.Remove(add);
    }
}
