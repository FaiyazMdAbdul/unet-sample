using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Playables;

public class UIManager : MonoBehaviour
{
    NetworkManager manager;

    [SerializeField] GameObject loginPanel;
    [SerializeField] PlayableDirector shootTimeline;

    [SerializeField] Animator animator;
     [SerializeField] NetworkAnimator networkAnimator;

     public enum AnimStates
    {
        WALK, RUN, IDLE,FLIP, JUMP, FALL, ATTACK, HIT, DEAD
    }

    private void Start()
    {
        manager = FindObjectOfType<NetworkManager>();
        loginPanel.SetActive(true);
    }

    public void Create()
    {
        manager.StartHost();
        loginPanel.SetActive(false);
    }

    public void Join()
    {
        manager.StartClient();
        loginPanel.SetActive(false);
    }


    public void ShootSequence() 
    {
        networkAnimator.SetTrigger("shoot"); // TODO Change to Switch case  to handle different animations 
        //animator.SetTrigger("shoot");
    }

     void SwitchAnim(AnimStates state)
    {
        string animName = "idle";
        switch (state)
        {
            case AnimStates.IDLE:
                animName = "idle";
                break;
        }

        //play animation in IRNumerator and wait until animation finished or use invoke for looping animation

    }


}
