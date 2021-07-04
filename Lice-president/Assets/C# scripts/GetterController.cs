using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterController : MonoBehaviour
{
    public GameObject getter;
    private Vector3 whereToSpawn;
    [Header("Time until the object is destroyed")]
    public float DestroySec = 10;
    [Header("The price of the getter")]
    public int PriceGetter = 50;
    [Header("The number of points added after the getter's work")]
    public int EarnedPoints = 100;
    public GameObject resourcesPanel;

    public void SpawnGetter()
    {
        whereToSpawn = new Vector3(-129, 11, 50);
        var lice = Instantiate(getter, whereToSpawn, Quaternion.identity) as GameObject;
        Destroy(lice, DestroySec);
        resourcesPanel.GetComponent<ResourcesController>().blood += EarnedPoints;
    }

    public void SpawnLice()
    {
        if(resourcesPanel.GetComponent<ResourcesController>().blood < PriceGetter)
        {
            return;
        }
        resourcesPanel.GetComponent<ResourcesController>().blood -= PriceGetter;
        SpawnGetter();
    }

}