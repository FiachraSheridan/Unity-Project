using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickRandomSprite : MonoBehaviour
{
    public Sprite[] possibleSprites;
    
    void Start()
    {
        pickRandomSprite();
    }

    public void pickRandomSprite()
    {
        int carPick = Random.Range(0, possibleSprites.Length);
        Sprite currentSprite = possibleSprites[carPick];
        SpriteRenderer spritePick = GetComponent<SpriteRenderer>();

        spritePick.sprite = currentSprite;
    }

}
