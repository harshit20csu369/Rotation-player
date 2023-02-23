using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class Node
{
    protected NodeState node;
    public NodeState _node
    {
        get { return _node; } 
    }

    public abstract NodeState Evaluate();


}

public enum NodeState
{
    RUNNING , SUCCESS ,FAILURE,
}
