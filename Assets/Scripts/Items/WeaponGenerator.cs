using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using rds;

public class WeaponGenerator : MonoBehaviour
{
		int areaLevel = 2;	
		RDSTable mainTable = new RDSTable ();
		void Start ()
		{
				switch (areaLevel) {
				case 0:
						mainTable.AddEntry (new RDSWeaponTable (0), 90);
						mainTable.AddEntry (new RDSWeaponTable (1), 5);
						mainTable.AddEntry (new RDSWeaponTable (2), 2);
						break;
				case 1:
						mainTable.AddEntry (new RDSWeaponTable (0), 80);
						mainTable.AddEntry (new RDSWeaponTable (1), 10);
						mainTable.AddEntry (new RDSWeaponTable (2), 4);
						break;
				case 2:
						mainTable.AddEntry (new RDSWeaponTable (0), 50);
						mainTable.AddEntry (new RDSWeaponTable (1), 20);
						mainTable.AddEntry (new RDSWeaponTable (2), 10);
						break;

				}
				
				
		}

		void Update ()
		{
				
				if (Input.GetKeyDown (KeyCode.A)) {
						for (int i = 0; i < 3; i++) {
								foreach (RDSWeaponTable w in mainTable.rdsResult) {
										Debug.Log (w.GetAffix ());
								}
						}
				}
		}


}
