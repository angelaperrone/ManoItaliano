//https://unity3d.com/learn/tutorials/modules/beginner/live-training-archive/audio
//http://docs.unity3d.com/ScriptReference/AudioSource.Play.html
//AV 'Sehyun Kim'

using UnityEngine;
using System.Collections;

public class pingScript : MonoBehaviour {
	//create boolean terms
	bool isStartedMoving;
	//declare vector 3 to control x y z axes
	Vector3 pos, pre_pos;

	void Start(){
		//boolean is false
		isStartedMoving = false;
		//pos = transform position set in unity
		pos = transform.position;
		//pre_pos = same as above pos
		pre_pos = transform.position;
	}

	void Update(){
		//pos is the current transform position
		pos = transform.position;

		//if pos.x and pre_pos.x do NOT equal each other, boolean is true, else it is not
		if (pos.x != pre_pos.x) {
			isStartedMoving = true;
		} else {
			isStartedMoving = false;
		}

		//Debug.Log (isStartedMoving);
		//pre_pos takes on the value of pos
		pre_pos = pos;
		//basically the first time through pos and pre_pos will be false so this will not do anything - the next times through they will not be equal, the boolean will evaluate to true and the code below will enable the audio to play on collision
	}

	//defines what happens when something hits the cube/the cube hits something
	void OnCollisionEnter (Collision col) {
		AudioSource audio = GetComponent<AudioSource> ();
		//play only when isStartedMoving is true - see above
		if (isStartedMoving) {
				audio.Play ();
		}
	}
}
