using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "CharactersController", menuName = "Controllers/CharactersController", order = 2)]
public class CharactersController : ScriptableObject {

	public List<CharacterEntry> characters;
	
	public void Init() {

	}
}

[System.Serializable]
public class CharacterEntry {

	public string name;
	public ACharacter character;
}