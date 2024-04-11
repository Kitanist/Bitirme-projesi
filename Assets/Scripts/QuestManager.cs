using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public List<Quest> quests = new List<Quest>();

    // Görev ekleme
    public void AddQuest(int questID)
    {
        quests[questID].isActive = true;
        GameManager.Instance.QuestTitle.text = quests[questID].questName;
        GameManager.Instance.QuestDesc.text = quests[questID].description;
    }

    // Görevi tamamlama
    public void CompleteQuest(int questID)
    {
        quests[questID].Complete();
        GameManager.Instance.Gold += quests[questID].rewardGold;
        GameManager.Instance.XP += quests[questID].rewardXP;
    }
}
