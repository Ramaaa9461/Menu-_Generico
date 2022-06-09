using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Jump : MonoBehaviour
{
    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void CubeJump()
    {
        animator.SetTrigger("Jump");
    }

}
