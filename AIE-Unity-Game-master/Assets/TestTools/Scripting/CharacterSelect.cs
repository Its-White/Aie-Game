using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterSelect : MonoBehaviour {

    public struct Selector
    {
        public List<Sprite> selectorImage;
    }

    void Start() {
        //The amount of players in the game are to be equal to the amount of selectors that get created
        for (int i = 0; i < Manager.players.Count; i++)
        {
            Instantiate(new GameObject(new Selector().ToString()));
        }
    }
    
}