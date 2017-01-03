using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

	public string Name;
    public enum Emotion { Normal, Happy, Sad, Angry }
	public Emotion currentEmotion;
	public Room currentRoom;
}
