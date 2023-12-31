using System;
using System.Collections;
using System.Collections.Generic;
using GameDevTV.Inventories;
using GameDevTV.Utils;
using UnityEngine;

namespace RPG.Quests
{
    [CreateAssetMenu(fileName = "Quest", menuName ="RPG Project/Quest", order = 0)]
    public class Quest : ScriptableObject
    {
        [SerializeField] List<Objective> objectives = new List<Objective>();
        [SerializeField] List<ItemRewards> rewards = new List<ItemRewards>();
        [SerializeField] List<ExperienceReward> experienceReward = new List<ExperienceReward>();

        [System.Serializable]
        public class ItemRewards
        {
            [Min(1)] public int number;
            public InventoryItem item;

        }

        [System.Serializable]
        public class ExperienceReward
        {
            public float experienceRewardAmount;
        }

        [System.Serializable]
        public class Objective
        {
            public string reference;
            public string description;
            public bool usesCondition = false;
            public Condition completionCondition;
        }
        public string GetTitle()
        {
            return name;
        }

        public int GetObjectiveCount()
        {
            return objectives.Count;
        }

        public IEnumerable<Objective> GetObjectives()
        {
            return objectives;
        }

        public IEnumerable<ExperienceReward> GetExperienceReward()
        {
            return experienceReward;
        }
        public IEnumerable<ItemRewards> GetRewards()
        {
            return rewards;
        }

        public bool HasObjective(string objectiveRef)
        {
            foreach (var objective in objectives)
            {
                if (objective.reference == objectiveRef)
                {
                    return true;
                }
            }
            return false;
        }

        public static Quest GetByName(string questName)
        {
            foreach (Quest quest in Resources.LoadAll<Quest>(""))
            {
                if (quest.name == questName)
                {
                    return quest;
                }
            }

            return null;
        }
    }
}
