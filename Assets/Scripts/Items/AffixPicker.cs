using Items;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using rds;

public class AffixPicker
{

    private RDSTable mainTableAffix;
		
		public AffixPicker (int areaLevel)
		{

            mainTableAffix = new RDSTable();
				
		}

    public void GenerateAffixTableOnArea(int areaLevel)
    {
        
        switch (areaLevel)
        {
            case 0:
                mainTableAffix.AddEntry(new RDSAffixHelper(1,Quality.Poor), 90);

                break;
            case 1:
                mainTableAffix.AddEntry(new RDSAffixHelper(1,Quality.Poor), 80);
                mainTableAffix.AddEntry(new RDSAffixHelper(2, Quality.Common), 50);
                mainTableAffix.AddEntry(new RDSAffixHelper(3, Quality.Rare), 4);
                break;
            case 2:
                mainTableAffix.AddEntry(new RDSAffixHelper(1, Quality.Poor), 100);
                mainTableAffix.AddEntry(new RDSAffixHelper(2,Quality.Rare), 100);
                mainTableAffix.AddEntry(new RDSAffixHelper(3, Quality.Fabled),1);
                break;

        }
    }

		public IEnumerable<IRDSObject> GetAffixFromTable ()
		{

		    return mainTableAffix.rdsResult;
		}


}
