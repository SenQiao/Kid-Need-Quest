using UnityEngine;
using System.Collections;

public class TextFieldz : MonoBehaviour {
	public string stringToEdit2 = "Sky Forest";
	void OnGUI() {
		//stringToEdit2 = GUI.TextField(new Rect(10, 10, 200, 20), stringToEdit2, 25);

		GUI.Label (new Rect (10, 10, 200, 20), stringToEdit2);
	}
}