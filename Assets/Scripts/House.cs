using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class House : MonoBehaviour
{
    public Transform Home, ExitHome;
    public GameObject Player;
    public CameraSmoother Cam;
    
    public void EnterHome()
    {
        enumeratorHome();
        Player.transform.position = Home.position;
    }
    public void ExitHomes()
    {
        enumeratorHome();
        Player.transform.position = ExitHome.position;
    }
    public IEnumerator enumeratorHome()
    {
        Cam.Aktif = false;
        yield return new WaitForSeconds(1);
        Cam.Aktif = true;
    }
  




}
