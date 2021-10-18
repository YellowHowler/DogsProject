using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DogBreed
{
    BichonFrise, Shiba, Poodle, GoldenRetriever, Husky, Pomeranian, Beagle, Dachshund, Maltese
}

public class GameManager : MonoBehaviour
{
    //item 관련 정보
    //money, diamond
    //dog 입양보낸 얘

    public static GameManager instance;

    public List<int> itemOccupiedList = new List<int>();

    private int itemCount = 50;
    private int money;
    private int diamond;
    private int dog;

    public DogBreed currentBreed = DogBreed.Husky;

    public void SaveItem()
    {
        for (int i = 0; i < itemOccupiedList.Count; i++)
        {
            PlayerPrefs.SetInt("Item" + i, itemOccupiedList[i]);
        }

        PlayerPrefs.Save();
    }

    public void SaveAsset()
    {
        PlayerPrefs.SetInt("Money", money);
        PlayerPrefs.SetInt("Diamond", diamond);
        PlayerPrefs.SetInt("Dog", dog);
    }

    public void LoadItem()
    {
        itemOccupiedList.Clear();

        for (int i = 0; i < itemCount; i++)
        {
            if (PlayerPrefs.HasKey("item" + i))
            {
                itemOccupiedList.Add(PlayerPrefs.GetInt("Item" + i));
            }

            else
            {
                itemOccupiedList.Add(0);
            }
        }
    }

    public void LoadAsset()
    {
        if (PlayerPrefs.HasKey("Money"))
        {
            money = PlayerPrefs.GetInt("Money");
        }

        if (PlayerPrefs.HasKey("Diamond"))
        {
            diamond = PlayerPrefs.GetInt("Diamond");
        }

        if (PlayerPrefs.HasKey("Dog"))
        {
            dog = PlayerPrefs.GetInt("Dog");
        }

    }

    void Initialize()
    {
        LoadItem();
        LoadAsset();
    }

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }

        Initialize();
    }

    void Start()
    {
       
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            SaveItem();
            SaveAsset();
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            Initialize();
        }
    }
}
