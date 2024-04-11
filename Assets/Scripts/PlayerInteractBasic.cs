using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractBasic : MonoBehaviour
{
    public bool IsDestroy;
    [SerializeField] private GameEvent _dialougeStarter;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _dialougeStarter.Raise();
        if (IsDestroy)
        {
            gameObject.SetActive(false);
        }
    }
}
