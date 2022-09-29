using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    public int bumpingCount = 0;

    private void OnCollisionEnter(Collision other) 
    {
        bumpingCount++;
        Debug.Log("You've bumped into a thing this many times: " + bumpingCount);
    }
}
