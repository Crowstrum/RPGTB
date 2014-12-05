using UnityEngine;
using System.Collections;

public interface IRDSObject {

    double rdsProbability { get; set; } //drop chance
    bool rdsUnique { get; set; } //only drops once per query
    bool rdsAlways { get; set; } // drops always
    bool rdsEnabled { get; set; } // can it drop now?

    event Eventhandler 

}
