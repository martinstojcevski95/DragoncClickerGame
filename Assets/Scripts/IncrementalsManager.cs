using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

namespace InfernoStudios
{
    public class IncrementalsManager : MonoBehaviour
    {
        public enum UpgradeType
        {
            GoldPerTap,
            PassiveIncome,
            Multiplier
        }

        private static IncrementalsManager _Instance;

        public static IncrementalsManager IncrementalsInstance { get { return _Instance; } }

        private float goldPerTap = 2;
        private float goldMultiplier = 2;
        private float passiveIncome = 1;



        public OnUpgradeComplete onUpgradeComplete = new OnUpgradeComplete();


        [SerializeField] Dictionary<UpgradeType, float> test = new Dictionary<UpgradeType, float>();

        private void Awake()
        {
            if (_Instance != null && _Instance != this)
                Destroy(this.gameObject);
            else
                _Instance = this;    
        }

        void Start()
        {
            test.Add(UpgradeType.GoldPerTap, goldPerTap);
            test.Add(UpgradeType.Multiplier, goldMultiplier);
            test.Add(UpgradeType.PassiveIncome, passiveIncome);
        }

        public void EarnGoldPerTap()
        {
            GameManager.Instance.PlayerGold += GoldPerTap;
        }

        void PassiveIncomeSystem()
        {
          
        }



        public float GoldPerTap
        {
            get { return test[UpgradeType.GoldPerTap]; }
            set { goldPerTap = value; }
        }

        public float GoldMultiplier
        {
            get { return test[UpgradeType.Multiplier]; }
            set { goldMultiplier = value; }
        }

        public float PassiveIncome
        {
            get { return test[UpgradeType.PassiveIncome]; }
            set { passiveIncome = value; }
        }


        public void Upgrade(UpgradeType key, float upgradeIncremental)
        {
            test[key] = upgradeIncremental;
            onUpgradeComplete?.Invoke(true);
        }





        public class OnUpgradeComplete : UnityEvent<bool>
        {
        
        }

    }
}

