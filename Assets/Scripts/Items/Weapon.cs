using UnityEngine;
using System.Collections;
using Items;
using Helpers;

public class Weapon :  BaseItem
{
	#region Fields
		public GameObject _weaponGameObj;
		public WeaponType _type;
		WeaponHands _hands;
		Quality _quality;
		ItemType _itemType;
		int _attackVal;
		int _attackBonus;
		int _damageVal;
		int _damageBonus;
	#endregion

	#region Properties
		public GameObject WeaponGameObj {
				get { return _weaponGameObj;}
				protected set { _weaponGameObj = value;} 
		}
		public WeaponType TypeOfWeapon {
				get { return _type;}
				protected set { _type = value;} 
		}
		public WeaponHands WeaponHanded {
				get { return _hands;}
				protected set { _hands = value;} 
		}
		public Quality WeaponQuality {
				get { return _quality;}
				protected set { _quality = value;} 
		}
		public ItemType WeaponItemType {
				get { return _itemType;}
				protected set { _itemType = value;} 
		}
		public int AttackValue {
				get { return _attackVal;}
				protected set { _attackVal = value;} 
		}
		public int AttackBonus {
				get { return _attackBonus;}
				protected set { _attackBonus = value;} 
		}
		public int DamageValue {
				get { return _damageVal;}
				protected set { _damageVal = value;} 
		}
		public int DamageBonus {
				get { return _damageBonus;}
				protected set { _damageBonus = value;} 
		}
	#endregion



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
