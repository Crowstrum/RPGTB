using UnityEngine;
using System.Collections;
using rds;
public class RDSWeaponTable :  RDSObject
{
		public string i;
		public int level;
		public RDSWeaponTable (int l)
		{
				level = l;
		}
		
		public string GetAffix ()
		{
				switch (level) {
				case 0:
						i = "none";
						break;
				case 1:
						i = "one";
						break;
				case 2:
						i = "two";
						break;
				case 3:
						i = "three";
						break;
				}
				return i;
		}
}
