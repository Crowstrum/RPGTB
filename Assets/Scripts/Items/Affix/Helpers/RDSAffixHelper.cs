using System.Collections.Generic;
using System.Runtime.InteropServices;
using Items;
using Items.Affix;
using UnityEngine;
using System.Collections;
using rds;

public class RDSAffixHelper : RDSObject
{
		
		public RDSAffixHelper ()
		{
				
		}

		public BaseAffix GetAffix (AffixItemType itemType)
		{
				return ItemManager.instance.RetrieveAffixFromList (itemType);
		}
}
