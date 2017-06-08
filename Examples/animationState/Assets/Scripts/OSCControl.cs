using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System;
using OSCsharp.Data;
using UniOSC;

public class OSCControl : UniOSCEventTarget {

	public String nextStateTrigger = "/1/push1";
	public String jumpOn = "/1/push2";

	Animator anim;
	int nextStateHash = Animator.StringToHash("nextState");
	int jumpOnHash = Animator.StringToHash("jumpOn");
	//int runStateHash = Animator.StringToHash("Base Layer.Run");

	private Vector3 pos;

	void Start ()
	{
		anim = GetComponent<Animator>();
	}

	void Awake(){
	}

	public override void OnEnable(){
		base.OnEnable();
	}

	void Update ()
	{
	}

	public override void OnOSCMessageReceived(UniOSCEventArgs args){

		//Debug.Log ( "Address:" + args.Address );

		OscMessage msg = (OscMessage)args.Packet;

		// check to make sure there is an argument
		if (msg.Data.Count <1) return;

		// receiving a message for going to next state?
		if (args.Address == nextStateTrigger) {
			if ((float)msg.Data [0] == 1.0) {
				anim.SetTrigger (nextStateHash);
			}
		}

		// receiving a message for initiating jump?
		if (args.Address == jumpOn) {
			if ((float)msg.Data [0] == 1.0) {
				anim.SetBool (jumpOnHash, true);
			} else {
				anim.SetBool (jumpOnHash, false);
			}
		}
	}
}