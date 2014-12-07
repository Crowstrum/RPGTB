using Items;
using UnityEngine;
using System.Collections;
using Items.Affix;

public class AgilityAffix :  BaseAffix {

    public AgilityAffix(int areaLevel, Quality quality )
    {
        Type = Items.Affix.Stats.Agility;
        Value = base.RandomAffixValue(areaLevel, quality);
        Name = GetSuffixName(Value);
    }

    private string GetSuffixName(int power)
    {
        if (power <= 4)
        {
            return " of the Snake";
        }
        if (power > 4 && power <= 8)
        {
            return " of the Tiger";
        }
        if (power > 8 && power <= 10)
        {
            return " of the Theif";
        }
        else
        {
            return "of the Flayer";
        }
    }

    public override void ApplyAffix(GameObject character)
    {
        throw new System.NotImplementedException();
    }
}
