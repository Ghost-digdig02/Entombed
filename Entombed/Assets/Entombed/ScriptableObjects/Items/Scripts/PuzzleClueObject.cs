using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// this script lets us create new puzzle clues items through the create asset menu inside of unity, 
/// and it sets the item type automatically for us, so we don't need to think about that :) 
/// </summary>

[CreateAssetMenu(fileName = "New Puzzle Clue", menuName = "Invetory System/Items/PuzzleClue")]
public class PuzzleClueObject : ItemObject
{
    //add any variables u need here
    public void Awake()
    {
        type = ItemType.PuzzelClue;
    }
}
