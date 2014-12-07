using System.Collections.Generic;
using System.Linq;
using Items.Affix;
using UnityEngine;
using System.Collections;
using Items;

public class GenerateItems : MonoBehaviour
{
    private int itemCount = 0;
    public WeaponHands handed;
    public WeaponType rangeType;
    public WeaponObj weaponObj;
    public Quality quality;
    public List<BaseAffix> ItemAffixs = new List<BaseAffix>();

    private AffixPicker affix;
	// Use this for initialization
	void Start () {
         affix = new AffixPicker(2);
	    
        
	
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(itemCount);
	    if (Input.GetKeyDown(KeyCode.Q))
	    {
	        GenerateItemDrop();
	    }
	    if (Input.GetKeyDown(KeyCode.A))
	    {
            affix.GenerateAffixTableOnArea(2);
           
                foreach (RDSAffixHelper a in affix.GetAffixFromTable())
                {
                    Debug.Log(string.Format("Suffix:{0} Amount:{1}", a.GetAffix().Name,a.GetAffix().Value));
                }
            
	    }
    }
    /// <summary>
    /// Main Method for creating Weapons and Armor Randomly
    /// </summary>
    public  void GenerateItemDrop()
    {
        
        PickWeaponHandAmount();
        PickWeaponTypeObj(handed);
        PickWeaponQuality(0);
        
        
    }

    private void PickWeaponHandAmount()
    {
        switch (Random.Range(0, 2))
        {
            case 0:
                handed = WeaponHands.OneHanded;
                break;
            case 1:
                handed = WeaponHands.TwoHanded;
                break;

        }
    }

    private void PickWeaponQuality(int area)
    {
        affix.GenerateAffixTableOnArea(area);

        foreach (RDSAffixHelper a in affix.GetAffixFromTable())
        {
            quality = a.GetAffix()._quality;
            ItemAffixs.Add(a.GetAffix());
        }
       
    }

    private void PickWeaponTypeObj(WeaponHands handAmount)
    {
        PickWeaponRangeType();
        if (handAmount == WeaponHands.OneHanded && rangeType == WeaponType.Melee)
        {
            switch (Random.Range(0, 2))
            {
                case 0:
                    weaponObj = WeaponObj.Dagger;
                    break;
                case 1:
                   weaponObj = WeaponObj.Sword;
                    break;

            }
            
        }
        else if (handAmount == WeaponHands.TwoHanded && rangeType == WeaponType.Melee)
        {
            switch (Random.Range(0, 2))
            {
                case 0:
                    weaponObj = WeaponObj.Axe;
                    break;
                case 1:
                    weaponObj = WeaponObj.Sword;
                    break;

            }
        }
        else if (handAmount == WeaponHands.OneHanded && rangeType == WeaponType.Ranged)
        {
            switch (Random.Range(0, 2))
            {
                case 0:
                    weaponObj = WeaponObj.Wand;
                    break;
                case 1:
                    weaponObj = WeaponObj.Wand;
                    break;

            }
        }
        else if (handAmount == WeaponHands.TwoHanded && rangeType == WeaponType.Ranged)
        {
            switch (Random.Range(0, 2))
            {
                case 0:
                    weaponObj = WeaponObj.Bow;
                    break;
                case 1:
                    weaponObj = WeaponObj.Bow;
                    break;

            }
        }

    }

    private void PickWeaponRangeType()
    {
        switch (Random.Range(0, 2))
        {
            case 0:
                rangeType = WeaponType.Melee;
                break;
            case 1:
                rangeType = WeaponType.Ranged;
                break;

        }
    }
}
