using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {

    Transform player;
    NavMeshAgent nav;
    private Animator anim;
	
    // Use this for initialization
	void Start () {

        player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();

    }
	
	// Update is called once per frame
	void Update () {
        
	}

    private void OnTriggerEnter(Collider other)
    {
        bool enter = true;
        anim.SetBool("Run", enter);
        nav.SetDestination(player.position);
    }

    private void OnTriggerExit(Collider other)
    {
        bool enter = false;
        anim.SetBool("Run", enter);
    }
}
