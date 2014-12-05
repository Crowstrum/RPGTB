using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public interface IRDSTable {
    int rdsCount { get; set; } //how many items can drop from this table
    IEnumerable<IRDSObject> rdsContents { get; } //the contents of this table
    IEnumerable<IRDSObject> rdsResult { get; } // the result set 
}
