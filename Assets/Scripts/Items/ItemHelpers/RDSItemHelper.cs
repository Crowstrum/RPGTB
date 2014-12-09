using UnityEngine;
using System.Collections;
using rds;

namespace Items
{

		public class RDSItemHelper : RDSObject
		{
				private int _tcLevel;
				public RDSItemHelper (int tc)
				{
						_tcLevel = tc;
				}
				
				public GameObject GetItem ()
				{
						return ItemManager.instance.RetrieveItemFromTreasureClass (_tcLevel);
				}
		}
}