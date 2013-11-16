using UnityEngine;
using System.Collections;

public class GoalBehavior : MonoBehaviour {
	
	public BallBehavior ballObject;
	public GUIBehavior scoreObject;
	public AudioClip AirHorn;
	
	void OnTriggerEnter (Collider collider) {
		if (collider.tag != "Ball")
			return; //don't do anything if it's not the ball

		// Increment variable to keep track of score
		if (this.tag == "BlueGoal")
			++ scoreObject.redScore;//increment RedScore
		
		else if (this.tag == "RedGoal")
			++ scoreObject.blueScore;//increment BlueScore
		
		AudioSource.PlayClipAtPoint(AirHorn, Camera.main.transform.position);
		
		yield return new WaitForSeconds (1);//to make it seems a bit less like magic
		
		//reset ball
		ballObject.Reset ();//reset ball
	}
}