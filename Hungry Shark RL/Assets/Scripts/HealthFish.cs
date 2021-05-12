using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthFish : Fish
{
    // Start is called before the first frame update
    void Start()
    {
        timeTilLeave = 6.0f;
    }

    // Update is called once per frame
    void Update()
    {
        base.Update();
        Debug.Log(timeTilLeave + " " + timeSinceAppeared);
    }
}
