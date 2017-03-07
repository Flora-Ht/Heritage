using UnityEngine;
using System.Collections;

public class Model : Singleton<Model> {

	public SceneController sceneController;
	public bool isInitialized = false;

	public void Init() {
	
		if (isInitialized) {
			return;
		}

		sceneController = (SceneController)Resources.Load ("SceneController");

		isInitialized = true;
	}
}
