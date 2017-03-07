using UnityEngine;
using System.Collections;
using System.Collections.Generic;

abstract public class ACharacter : MonoBehaviour {

	public string Name;
    public enum Emotion { Normal, Happy, Sad, Angry }
	public Emotion currentEmotion;
	public Room currentRoom;
	public List<CharacterEmotionSprite> sprites;
}

[System.Serializable]
public class CharacterEmotionSprite {

	public ACharacter.Emotion emotion;
	public SpriteRenderer image;
}