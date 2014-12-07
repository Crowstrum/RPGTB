using System.Collections.Generic;
using Items.Affix;
using UnityEngine;
using System.Collections;
using Items;
using Helpers;

public class Weapon :  BaseItem
{
	#region Fields

    public List<BaseAffix> ItemAffixs = new List<BaseAffix>();
        GameObject _weaponGameObj;
		WeaponType _type;
		WeaponHands _hands;
		Quality _quality;
		ItemType _itemType;
    private WeaponObj _weaponObj;
		int _attackVal;
		int _attackBonus;
		int _damageVal;
		int _damageBonus;
	#endregion

	#region Properties
		public GameObject WeaponGameObj {
				get { return _weaponGameObj;}
				 set { _weaponGameObj = value;} 
		}
		public WeaponType TypeOfWeapon {
				get { return _type;}
				 set { _type = value;} 
		}
		public WeaponHands WeaponHanded {
				get { return _hands;}
				 set { _hands = value;} 
		}
		public Quality WeaponQuality {
				get { return _quality;}
				 set { _quality = value;} 
		}
		public ItemType WeaponItemType {
				get { return _itemType;}
				 set { _itemType = value;} 
		}
		public int AttackValue {
				get { return _attackVal;}
				 set { _attackVal = value;} 
		}
		public int AttackBonus {
				get { return _attackBonus;}
				 set { _attackBonus = value;} 
		}
		public int DamageValue {
				get { return _damageVal;}
				 set { _damageVal = value;} 
		}
		public int DamageBonus {
				get { return _damageBonus;}
				 set { _damageBonus = value;} 
		}

    public WeaponObj WeaponObj
    {
        get { return _weaponObj; }
        protected set { _weaponObj = value; }
    }

    void Start()
    {
       
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
