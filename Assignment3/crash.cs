//https://unity3d.com/learn/tutorials/modules/beginner/live-training-archive/audio
//http://docs.unity3d.com/ScriptReference/AudioSource.Play.html

using UnityEngine;
using System.Collections;


public class crash : MonoBehaviour {

	//create collision function
	void OnCollisionEnter (Collision col) 
	{
		//call audio source by getting component
		AudioSource audio = GetComponent<AudioSource> ();

		//play audio
		audio.Play ();
	}

}