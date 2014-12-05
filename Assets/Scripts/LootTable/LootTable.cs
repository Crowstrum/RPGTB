using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using rds;

public class LootTable : MonoBehaviour {
    RDSTable table = new RDSTable();
    public List<Item> items;
	// Use this for initialization
	void Start () {

        foreach (Item go in items)
        {
            table.AddEntry(go);
        }

        
	
	}

    // Update is called once per frame
    void Update()
    {
        
	    if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("hERE");
            table.rdsCount = 2;

        for (int i = 0; i < 3; i++)
        {
            Debug.Log(table.rdsResult.GetEnumerator().MoveNext().ToString());
            foreach (Item item in table.rdsResult)
            {
                Debug.Log("Item Looted: " + item.name);
            }
        }
        }
	}
}
