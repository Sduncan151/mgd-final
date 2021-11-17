using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class FindPlayerForConstraint : MonoBehaviour
{
    public Transform player;
    public ConstraintSource source;

    public 

    // Start is called before the first frame update
    void Start()
    {
        // make a reference to the position constraint
        PositionConstraint pc = this.GetComponent<PositionConstraint>();
        // RotationConstraint rc = this.GetComponent<RotationConstraint>();
        // find player
         if(player == null)
        {
            player = GameObject.FindWithTag("Player").transform;
        }
        source.sourceTransform = player;
        source.weight = 1;
        pc.AddSource(source);
        pc.constraintActive = true;

        // rc.AddSource(source);
        // rc.constraintActive = true;
    }
}
