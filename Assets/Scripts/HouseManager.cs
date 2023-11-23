using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HouseManager : MonoBehaviour
{
    [SerializeField] private GameEvent _dialougeStarter;
    public string[] Sahneler;
    
    public string GetHouse()
    {
        int randomise = Random.Range(0, Sahneler.Length);
        string HouseName;
        HouseName = Sahneler[randomise];
        return HouseName;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _dialougeStarter.Raise();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(GetHouse());
        }
    }
}
