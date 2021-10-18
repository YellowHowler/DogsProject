using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int hp = 0;
    private int defense = 0;
    private float moveSpeed = 0f;

    private bool noticeObstacle = false;

    public DogBreed currentBreed = DogBreed.Husky;

    private void Start()
    {
        switch(GameManager.instance.currentBreed)
        {
            case DogBreed.Beagle:
                break;

            case DogBreed.BichonFrise:
                break;

            case DogBreed.Dachshund:
                break;

            case DogBreed.GoldenRetriever:
                break;

            case DogBreed.Husky:
                break;

            case DogBreed.Maltese:
                break;

            case DogBreed.Pomeranian:
                break;

            case DogBreed.Poodle:
                break;

            case DogBreed.Shiba:
                break;
        }
    }

    void initializeDog(int hp, float moveSpeed, int defense, bool noticeObstacle)
    {
        this.hp = hp;
        this.moveSpeed = moveSpeed;
        this.defense = defense;
        this.noticeObstacle = noticeObstacle;
    }
}