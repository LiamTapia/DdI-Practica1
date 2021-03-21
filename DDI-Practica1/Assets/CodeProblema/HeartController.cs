using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour
{
    public int currentLife = 3;
    public int maxLife = 13;
    public int minLife = 1;

    public GameObject heartPrefab;


    public void Start()
    {
        DeleteChilds();

        for(int i = 0; i < currentLife; i++)
        {
            GameObject childHeart = Instantiate(heartPrefab) as GameObject; 
            childHeart.transform.SetParent(GameObject.Find("HeartContainer").transform,false);
           //this.transform.SetParent(obj.transform, false);

        }
    }

    public void UpdateLife(int lifeChange)
    {
        DeleteChilds();

        currentLife += lifeChange;

        for(int i = 0; i < currentLife; i++)
        {
            GameObject childHeart = Instantiate(heartPrefab) as GameObject; 
            childHeart.transform.SetParent(GameObject.Find("HeartContainer").transform,false);
        }
    }

    public void DeleteChilds()
    {
        int child = transform.childCount;
        for (int i = 0; i < child; i++)
        {
            GameObject.Destroy(transform.GetChild(i).gameObject);
        }
    }
}
