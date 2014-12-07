using Items;
using UnityEngine;
using System.Collections;
using Items.Affix;

public class StrengthAffix :  BaseAffix {

    public StrengthAffix(int areaLevel,Quality quality)
    {
        Type = Items.Affix.Stats.Strength;
        Value = base.RandomAffixValue(areaLevel,quality);
        Name = GetSuffixName(Value);
    }

    private string GetSuffixName(int power)
    {
        if (power <= 4)
        {
            return " of the Bear";
        }
        if (power > 4 && power <= 8)
        {
            return " of the Elephant";
        }
        if (power > 8 && power <= 10)
        {
            return " of the Ursa";
        }
        else
        {
            return "of the Void";
        }
    }

    public override void ApplyAffix(GameObject character)
    {
        throw new System.NotImplementedException();
    }
}
