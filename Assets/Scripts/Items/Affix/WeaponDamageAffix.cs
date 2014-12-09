using Items;
using UnityEngine;
using System.Collections;
using Items.Affix;

public class WeaponDamageAffix :  BaseAffix
{
		

		public WeaponDamageAffix ()
		{
				affixType = AffixItemType.Weapon;
				//Value = base.RandomAffixValue (areaLevel, quality);
				//Name = GetSuffixName (Value);
		}
		
		private string GetSuffixName (int power)
		{
				if (power <= 4) {
						return " of the Backstabber";
				}
				if (power > 4 && power <= 8) {
						return " of Striking";
				}
				if (power > 8 && power <= 10) {
						return " of the Beast";
				} else {
						return " of the Void";
				}
		}

		public override void ApplyAffix (GameObject character)
		{
				throw new System.NotImplementedException ();
		}

		public override void ApplyAffixWeapon (Weapon weapon)
		{
				base.ApplyAffixWeapon (weapon);
				int modifier = RandomAffixValue (weapon._quality, weapon._itemLevel);
				weapon._baseDamageMin += modifier;
				weapon._baseDamageMax += modifier;
				weapon._itemName = weapon._itemName + GetSuffixName (modifier);
		}
}
