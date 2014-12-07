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
        Mana
    }

    public abstract class BaseAffix
    {
        #region Fields
        private string _name;
        private Stats _type;
        private int _value;
        public Quality _quality;

        #endregion

        #region Methods

        public string Name
        {
            get { return _name; }
            protected set { _name = value; }
        }

        public Stats Type
        {
            get { return _type; }
            protected set { _type = value; }
        }

        public int Value
        {
            get { return _value; }
            protected set { _value = value; }
        }
        /// <summary>
        /// Sets random affix value based on area level
        /// </summary>
        /// <param name="power">Area Level</param>
        public int RandomAffixValue(int power, Quality quality)
        {
            int pow = 0;
            switch (quality)
            {
                case Quality.Poor :
                    pow = Random.Range(1, 4);
                    _quality = Quality.Poor;
                    break;
                case Quality.Common:
                    pow = Random.Range(1, 6);
                    _quality = Quality.Common;
                    break;
                case Quality.Rare:
                    pow = Random.Range(1, 8);
                    _quality = Quality.Rare;
                    break;
                case Quality.Fabled:
                    pow = Random.Range(5, 10) * power;
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
        public abstract void ApplyAffix(GameObject character); //used to apply this affix to character

        public virtual void ApplyAffixWeapon(GameObject weapon)
        {
            
        }

        #endregion



    }
}
