using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Playables;

public class UIManager : MonoBehaviour
{
    NetworkManager manager;

    [SerializeField] GameObject loginPanel;

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

   [SerializeField] PlayableDirector shootTimeline;

    [SerializeField] Animator animator;
    public void ShootSequence()
    {
        animator.gameObject.GetComponent<NetworkAnimator>().SetTrigger("shoot");
        //animator.SetTrigger("shoot");
    }

}
