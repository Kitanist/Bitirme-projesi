using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueSystemWithText;


public class DialougeMaster : MonoSingeleton<DialougeMaster>
{
    [SerializeField] DialogueUIController diyalogController,diyalogStarter;
    public CameraSmoother MainCamFollow;
    public GameObject MainCam,pos1,pos2,pos3;
    [SerializeField]  private PlayerMovement Player;
    void Start()
    {
        
        LeanTween.move(MainCam, pos1.transform, 10f);
        Invoke(nameof(Loop),10f);
    }
    public void Loop()
    {
        diyalogStarter.ShowDialogueUI();
        LeanTween.move(MainCam, pos2.transform, 10f);
        Invoke(nameof(Loop2), 10f);
    }
    public void Loop2()
    {
        LeanTween.move(MainCam, pos3.transform, 10f);

        Invoke(nameof(StartDialouge), 10f);
        Invoke(nameof(StartCamFollow), 10f);
    }
    
    public void StartDialouge()
    {
        diyalogController.ShowDialogueUI();
    }
   public void StopToDialogueEnd()
    {
        Player.CanMove = false;
    }
    public void DialogueEnd()
    {
        Player.CanMove = true;
    }
    public void StopCamFollow()
    {
        MainCamFollow.enabled = false;
    }
    public void StartCamFollow()
    {
        MainCamFollow.enabled = true;
    }
   
}
