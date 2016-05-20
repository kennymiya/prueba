using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Botones : MonoBehaviour {

	Button startss;
	Button option;
	Button credits;

	void Start () {
	
		startss=GetComponent<Button> ();
		option =GetComponent<Button> ();
		credits =GetComponent<Button> ();
		//back = GameObject.Find ("back").GetComponent<Button> ();
		cambios ();


	}
	void cambios(){
		switch (gameObject.name) {
		case "start":
			
			startss.onClick.AddListener (() => goGame ());
			break;
		case "options":
			option.onClick.AddListener (() => goOptions ());
			break;
		case "credits":
			credits.onClick.AddListener (() => goCredits ());
			break;
	
		}
		
	}

	void goGame(){
		
		SceneManager.LoadScene ("Game");
	
	}
	void goOptions(){

		SceneManager.LoadScene ("Options");
	

	}
	void goCredits(){

		SceneManager.LoadScene ("Credits");


	}

	// Update is called once per frame
	void Update () {
	
	}
}
