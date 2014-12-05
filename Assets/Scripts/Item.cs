using UnityEngine;
using System.Collections;
using rds;

public class Item : RDSObject {

    public string name;
    public bool mdynamic = false;

    public override void OnRDSPreResultEvaluation(System.EventArgs e)
    {
        //base.OnRDSPreResultEvaluation(e);
        if (mdynamic)
        {
            rdsProbability *= 1.05;

        }
    }

    public override void OnRDSHit(System.EventArgs e)
    {
        //base.OnRDSHit(e);
        if (mdynamic)
        {
            rdsProbability = 1;
            Debug.Log("Dynamic hit reset to 1");
        }
    }


}
