using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    public Animator animator;
    int horizonal;
    int vertical;

    public void Awake()
    {
        animator = GetComponent<Animator>();
        horizonal = Animator.StringToHash("Horizonal");
        vertical = Animator.StringToHash("Vertical");
    }

    public void PlayTargetAnimation(string targetAnimation, bool isInteracting)
    {
        animator.SetBool("isInteracting", isInteracting);
        animator.CrossFade(targetAnimation,0.2f);
    }


    public void UpdateAnimatorValues(float horizonalMovement, float verticalMovement, bool isSprinting)
    {
        // Animation Snapping
        float snappedHorizonal;
        float snappedVertical;

        // some horizontal animation adjustments
        if (horizonalMovement > 0 && horizonalMovement < 0.55f)
        {
            snappedHorizonal = 0.5f;
        }
        else if (horizonalMovement > 0.55f)
        {
            snappedHorizonal = 1;
        }
        else if (horizonalMovement < 0 && horizonalMovement > -0.55f)
        {
            snappedHorizonal = -0.5f;
        }
        else if (horizonalMovement > -0.55f)
        {
            snappedHorizonal = -1;
        }
        else
        {
            snappedHorizonal = 0;
        }
        
        // Vertical adjustments for the animations
        if (verticalMovement > 0 && verticalMovement < 0.55f)
        {
            snappedVertical = 0.5f;
        }
        else if (verticalMovement > 0.55f)
        {
            snappedVertical = 1;
        }
        else if (verticalMovement < 0 && verticalMovement > -0.55f)
        {
            snappedVertical = -0.5f;
        }
        else if (verticalMovement > -0.55f)
        {
            snappedVertical = -1;
        }
        else
        {
            snappedHorizonal = horizonalMovement;
            snappedVertical = 0;
        }

        if (isSprinting)
        {
            snappedVertical = 2;
        }

        animator.SetFloat(horizonal, snappedHorizonal, 0.1f, Time.deltaTime);
        animator.SetFloat(vertical, snappedVertical, 0.1f, Time.deltaTime);
    }




}
