using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Items
{
		public enum ItemType
		{
				Weapon,
				Armor
		}
		public enum WeaponHanded
		{
				OneHanded,
				TwoHanded
		}
		public enum WeaponRange
		{
				Melee,
				Ranged
		}
		public enum ArmorLocation
		{
				Head,
				Chest,
				Hands,
				Feet
		}
		public enum ArmorType
		{
				Light,
				Medium,
				Heavy
		}
		public enum Quality
		{
				Poor,
				Common,
				Uncommon,
				Rare,
				Fabled
		}

		public enum WeaponType
		{
				Sword,
				Bow,
				Dagger,
				Axe,
				Wand
		}

		public abstract class BaseItem : MonoBehaviour
		{
		#region Item Fields
				public Affix.AffixItemType affixType;
				public string _itemName;
				public int _buyPrice;
				public int _sellPrice;
				public Quality _quality;
				public WeaponHanded _handed;
				public WeaponRange _weaponRange;
				public WeaponType _typeOfWeapon;
				public ItemType _itemType;
				bool _equipped;
				bool _hasSockets;
				GameObject[] _sockets;
				int _numberOfSockets;
				GameObject[] _affixs;

		#endregion

		#region Item Properties
				/// <summary>
				/// Gets or sets the name.
				/// </summary>
				/// <value>The name.</value>
				public string Name {
						get { return _itemName;}
						set { _itemName = value;}
				}
				/// <summary>
				/// Gets or sets the buy price.
				/// </summary>
				/// <value>The buy price.</value>
				public int BuyPrice {
						get { return _buyPrice;}
						set { _buyPrice = value;}
				}
				/// <summary>
				/// Gets or sets the sell price.
				/// </summary>
				/// <value>The sell price.</value>
				public int SellPrice {
						get { return _sellPrice;}
						set { _sellPrice = value;}
				}
				/// <summary>
				/// Gets or sets a value indicating whether this <see cref="Items.BaseItem"/> is equipped.
				/// </summary>
				/// <value><c>true</c> if equipped; otherwise, <c>false</c>.</value>
				public bool Equipped {
						get { return _equipped;}
						set { _equipped = value;}
				}
				/// <summary>
				/// Gets or sets a value indicating whether this instance has sockets.
				/// </summary>
				/// <value><c>true</c> if this instance has sockets; otherwise, <c>false</c>.</value>
				public bool HasSockets {
						get { return _hasSockets;}
						set { _hasSockets = value;}
				}
				/// <summary>
				/// Gets or sets the sockets.
				/// </summary>
				/// <value>The sockets.</value>
				public GameObject[] Sockets {
						get { return _sockets;}
						set { _sockets = value;}
				}
				/// <summary>
				/// Gets the socket item.
				/// </summary>
				/// <returns>The socket item.</returns>
				/// <param name="index">Index.</param>
				public GameObject GetSocketItem (int index)
				{
						return _sockets [index];
				}
				/// <summary>
				/// Sets the socket item.
				/// </summary>
				/// <param name="index">Index.</param>
				/// <param name="item">Item.</param>
				public void SetSocketItem (int index, GameObject item)
				{
						_sockets [index] = item;
				}
				/// <summary>
				/// Gets or sets the number of sockets.
				/// </summary>
				/// <value>The number of sockets.</value>
				public int NumberOfSockets {
						get { return _numberOfSockets;}
						set { _numberOfSockets = value;}
				}
				/// <summary>
				/// Gets or sets the affixs.
				/// </summary>
				/// <value>The affixs.</value>
				public GameObject[] Affixs {
						get { return _affixs;}
						set { _affixs = value;}
				}
		#endregion

		#region Constructor
				/*
				public BaseItem (string name, int buyprice, int sellprice)
				{
						Name = name;
						BuyPrice = buyprice;
						SellPrice = sellprice;
						Equipped = false;
				}
				*/
		#endregion

				public virtual void SetQuality (Quality quality)
				{
						_quality = quality;
				}
				public virtual void SetHanded (WeaponHanded handed)
				{
						_handed = handed;
				}
				public virtual void SetQuality (WeaponRange range)
				{
						_weaponRange = range;
				}
				public virtual void SetQuality (ItemType type)
				{
						_itemType = type;
				}
		#region Abstract Methods
				
				public abstract GameObject Clone (); //returns item from manager
				public abstract void Equip (GameObject character); //equips item on given character
		#endregion

		}
}
