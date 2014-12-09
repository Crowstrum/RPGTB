using UnityEngine;
using System.Collections;

namespace Items.Affix
{
		public enum Stats
		{
				Wisdom,
				Intelligence,
				Agility,
				Health,
				Strength,
				Mana,
				minDam,
				maxDam
		}
		
		public enum AffixItemType
		{
				Armor,
				Weapon
		}

		public abstract class BaseAffix
		{
        #region Fields
				private string _name;
				private Stats _type;
				private int _value;
				public Quality _quality;
				protected AffixItemType affixType;

        #endregion

        #region Methods
				public AffixItemType GetAffixType ()
				{
						return affixType;
				}

				public string Name {
						get { return _name; }
						protected set { _name = value; }
				}

				public Stats Type {
						get { return _type; }
						protected set { _type = value; }
				}

				public int Value {
						get { return _value; }
						protected set { _value = value; }
				}
				/// <summary>
				/// Sets random affix value based on area level
				/// </summary>
				/// <param name="power">Area Level</param>
				public int RandomAffixValue (Quality quality, int itemLevel)
				{
						int pow = 0;
						switch (quality) {
						case Quality.Poor:
								pow = 1 * itemLevel;
								_quality = Quality.Poor;
								break;
						case Quality.Common:
								pow = Random.Range (1, 6) * itemLevel;
								_quality = Quality.Common;
								break;
						case Quality.Rare:
								pow = Random.Range (1, 8) * itemLevel;
								_quality = Quality.Rare;
								break;
						case Quality.Fabled:
								pow = Random.Range (5, 10) * itemLevel * 2;
								_quality = Quality.Fabled;
								break;
              
						}
						return pow;
				}
       
        #endregion

        #region Abstract Methods
				/// <summary>
				/// Applies this affix to current character, when equipped.
				/// </summary>
				/// <param name="character"></param>
				public abstract void ApplyAffix (GameObject character); //used to apply this affix to character

				public virtual void ApplyAffixWeapon (Weapon weapon)
				{
            
				}

        #endregion



		}
}
