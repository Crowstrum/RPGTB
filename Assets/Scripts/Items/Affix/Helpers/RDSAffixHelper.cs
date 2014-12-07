using System.Collections.Generic;
using System.Runtime.InteropServices;
using Items;
using Items.Affix;
using UnityEngine;
using System.Collections;
using rds;

public class RDSAffixHelper : RDSObject
{
    private List<BaseAffix> affixList;
    private BaseAffix affix;
    public RDSAffixHelper(int areaLevel, Quality quality)
    {
        affixList = new List<BaseAffix>();
        affixList.Add(new StrengthAffix(areaLevel,quality));
        affixList.Add(new AgilityAffix(areaLevel,quality));
        affix = affixList[Random.Range(0, affixList.Count)];
    }

    public BaseAffix GetAffix()
    {
        return affix;
    }
}
