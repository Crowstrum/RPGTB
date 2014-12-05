using UnityEngine;
using System.Collections;
using rds;

public class RDSNullValue : RDSValue<object> {

    public RDSNullValue(double probability) : base(null, probability, false, false, true) { }
}
