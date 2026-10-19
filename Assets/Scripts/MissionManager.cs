using UnityEngine;
using System;

public class MissionManager : MonoBehaviour
{
    public string currentMission = "Explore the city";
    public bool missionCompleted = false;
    public int rewardMoney = 250;

    public event Action<string> OnMissionChanged;
    public event Action<int> OnMissionCompleted;

    public void StartMission(string missionName, int reward)
    {
        currentMission = missionName;
        rewardMoney = Mathf.Max(0, reward);
        missionCompleted = false;

        OnMissionChanged?.Invoke(currentMission);
    }

    public void CompleteMission()
    {
        if (missionCompleted)
            return;

        missionCompleted = true;
        OnMissionCompleted?.Invoke(rewardMoney);

        Debug.Log("Mission completed! Reward: " + rewardMoney);
    }
}
