using UnityEngine;
using System.Collections;

public class music : MonoBehaviour {

	AudioSource musica;
	public static music instance;
	void Awake(){
		instance = this;
		DontDestroyOnLoad (gameObject);
	}
	void Start(){
		playMusic ();
	}
	public void playMusic () {
		musica = GameObject.Find("audiosourceMusica").GetComponent<AudioSource>();
		musica.Play ();
		PlayerPrefs.SetFloat ("volumenambiente", musica.volume);
	}
	public void stopMusic(){
		musica.Stop ();
	}

}
