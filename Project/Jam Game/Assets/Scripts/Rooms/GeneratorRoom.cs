using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorRoom : BaseRoom {

    public int CurrentPowerOutput { get; private set; }

    // Override Activate to include generator-specific logic
    public override void Activate() {
        base.Activate();
        // Additional generator activation logic
        Debug.Log($"{gameObject.name} is now generating power.");
    }

    // Override Deactivate to handle generator-specific logic
    public override void Deactivate() {
        base.Deactivate();
        // Additional generator deactivation logic
        Debug.Log($"{gameObject.name} stopped generating power.");
    }
}
