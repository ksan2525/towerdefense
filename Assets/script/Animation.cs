using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : StateMachineBehaviour
{
    // Start is called before the first frame update
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log(stateInfo.normalizedTime);
    }
}
