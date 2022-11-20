using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New card", menuName = "Deck component")]
public class Cards_ : ScriptableObject
{
    public new string name;
    public string description;

    public float manaCost = 0f;

    public Sprite artwork;


}
