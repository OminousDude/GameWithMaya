using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyGFX : MonoBehaviour
{
    public AIPath path;

    void Update()
    {
        if (path.desiredVelocity.x >= 0.01f)
        {
            transform.localScale = new Vector3(7.5f, 7.5f, 1f);
        }
        else if (path.desiredVelocity.x <= -0.01f)
        {
            transform.localScale = new Vector3(-7.5f, 7.5f, 1f);
        }
    }
}
