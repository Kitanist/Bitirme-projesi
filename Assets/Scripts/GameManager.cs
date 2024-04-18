using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoSingeleton<GameManager>
{
    public AudioClip StartMusic,NormalMusic;
    public AudioSource SourceAudio;
    public GameObject Envanter;
    public GameObject ESC;
    public GameObject SkillTree;
    public GameObject QuestUI;
    public TextMeshProUGUI QuestTitle, QuestDesc;
    public Image HealthBar,XPBar;
    public float Health;
    public int Gold,XP;
    public GameEvent GoToVillageEvent;
    public static int MaxXp=100, MaxHealth=100;
    private void Start()
    {
        Health = 100;
        SourceAudio.PlayOneShot(StartMusic);
    }
    public void StopMusic()
    {
        SourceAudio.Stop();
    }
    public void StartNormalMusic()
    {
        SourceAudio.PlayOneShot(NormalMusic);
    }
    void Update()
    {
        HealthBar.fillAmount = Health/MaxHealth;
        XPBar.fillAmount = XP/MaxXp;
        if (Input.GetKeyDown(KeyCode.E))
        {
            Envanter.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ESC.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            SkillTree.SetActive(true);
        }
    }
    public void CloseUI()
    {
        SkillTree.SetActive(false);
        ESC.SetActive(false);
        Envanter.SetActive(false);
    }
    public void OpenQuestUI()
    {
        QuestUI.SetActive(true);GoToVillageEvent.Raise();
    }
    public void CloseQuestUI()
    {
        QuestUI.SetActive(false);
        

    }
}
