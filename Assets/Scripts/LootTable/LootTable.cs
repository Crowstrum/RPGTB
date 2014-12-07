using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using rds;

public class LootTable : MonoBehaviour
{
		RDSTable table = new RDSTable ();
		RDSTable goldTable = new RDSTable ();
		public List<Item> items;
		// Use this for initialization
		void Start ()
		{
				goldTable.AddEntry (new Gold (100, 10), 10);
				//table.AddEntry (goldTable, 50);

				foreach (Item go in items) {
						table.AddEntry (go, 10);
						
				}

        
	
		}

		// Update is called once per frame
		void Update ()
		{
        
				if (Input.GetKey (KeyCode.A)) {
						Debug.Log ("hERE");
						table.rdsCount = 2;

						
						//Debug.Log (table.rdsResult.GetEnumerator ().MoveNext ().ToString ());
						foreach (Item item in table.rdsResult) {
								if (item is Item) {
										Debug.Log ("Item Looted: " + item.name);
								} 
						}
						foreach (Gold g in goldTable.rdsResult) {
								Debug.Log (g.rdsValue);
						}
								
						
				}
		}
}
