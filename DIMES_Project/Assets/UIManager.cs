using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    List<GameObject> star;

    [SerializeField]
    List<GameObject> heart;

    private int starCount;
    private int heartCount;


    // Start is called before the first frame update

    private void Awake()
    {

        for (int i = 0; i < 5; i++)
        {
            star[i].SetActive(false);
            heart[i].SetActive(false);
        }
    }

    private void Start()
    {
        starCount = GameManager.instance.getStar();
        heartCount = GameManager.instance.getHp();
        if (heartCount < 1)
        {
            heartCount++;
        }

        for (int i = 0; i < starCount; i++)
        {
            star[i].SetActive(true);
        }


        for (int i = 0; i < heartCount; i++)
        {
            heart[i].SetActive(true);
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void addHP()
    {
        if (heartCount < 6)
        {
            heart[heartCount].SetActive(true);
            heartCount++;
        }
    }

    public void minusHP()
    {
        if (heartCount > 0)
        {
            heart[heartCount].SetActive(false);
            heartCount--;
        }
    }

    public void addStar()
    {
        if (starCount < 6)
        {
            star[starCount].SetActive(true);
            starCount++;
        }
    }
}
