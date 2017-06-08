using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System;
using OSCsharp.Data;
using UniOSC;


public class OSCReceiveSimple :  UniOSCEventTarget {

	public float range = 1;

	private Vector3 pos;

	void Awake(){
	}

	public override void OnEnable(){
		base.OnEnable();
	}


	public override void OnOSCMessageReceived(UniOSCEventArgs args){

		float x = transform.position.x;
		float y = transform.position.y;
		float z = transform.position.z;

		// Assumes receiving two arguments from OSC message: x,y
		//
		OscMessage msg = (OscMessage)args.Packet;

		// check for 1st argument, set x to it * range
		if (msg.Data.Count <1) return;
		x = (float)msg.Data[0] * range;

		// check for 2nd argument, set y to it * range
		if(msg.Data.Count >= 2){
			y = (float)msg.Data[1] * range;
		}

		// create new position and set object to it
		pos = new Vector3(x,y,z);
		transform.position = pos;


	}

}
