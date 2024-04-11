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
    public Slider HealthBar;
    public float Health;
    public int Gold,XP;
    public GameEvent GoToVillageEvent;
    private void Start()
    {
        Health = 1;
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
        HealthBar.value = Health;
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
