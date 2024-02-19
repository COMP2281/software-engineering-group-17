using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State_Machine : MonoBehaviour
{
    protected State State;

    public void Set_State(State state)
    {
        State = state;
        StartCoroutine(State.Start());
    }
}
