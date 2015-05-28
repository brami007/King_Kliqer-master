using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {
	

	
	// Use this for initialization
	void Start () {	
	}
	
	public void OnMouseDownStart() {
		Application.LoadLevel ("clicker");
	}

	public void OnMouseDownExit() {
		Application.Quit ();
	}

	public void OnMouseDownTitle()
	{
		Application.CancelQuit ();
		Application.LoadLevel ("title");
	}

}
