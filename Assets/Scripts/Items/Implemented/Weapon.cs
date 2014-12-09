using System.Collections.Generic;
using Items.Affix;
using UnityEngine;
using System.Collections;
using Items;
using Helpers;

public class Weapon :  BaseItem
{
	#region Fields

		public List<BaseAffix> ItemAffixs = new List<BaseAffix> ();
		GameObject _weaponGameObj;
		public int _baseDamageValMinLower;
		public int _baseDamageValMinHigher;
		public int _baseDamageValMaxLower;
		public int _baseDamageValMaxHigher;
		public int _basedamageBonus;
		public int _baseDamageMin;
		public int _baseDamageMax;
		public int _itemLevel;
	#endregion

		void Start ()
		{
				CalculatedBaseStats ();
				ApplyAfixToItem ();
		}

		public void CalculatedBaseStats ()
		{
				_baseDamageMin = Random.Range (_baseDamageValMinLower, _baseDamageValMinHigher);
				_baseDamageMax = Random.Range (_baseDamageValMaxLower, _baseDamageValMaxHigher);
		}
		
		public void ApplyAfixToItem ()
		{
				foreach (BaseAffix affix in ItemAffixs) {
						affix.ApplyAffixWeapon (this);
				}
		}


	#region implemented abstract members of BaseItem

		public override GameObject Clone ()
		{
				throw new System.NotImplementedException ();
		}

		public override void Equip (GameObject character)
		{
				throw new System.NotImplementedException ();
		}

	#endregion

	
}
