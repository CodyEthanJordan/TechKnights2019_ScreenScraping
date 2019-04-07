using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    class CharacterMaker : MonoBehaviour
    {
        public List<StatController> Stats;

        private int _unspentPoints = 0;
        public int UnspentPoints
        {
            private set
            {
                _unspentPoints = value;
                UnspentPointsText.text = "Unspent Points: " + _unspentPoints.ToString();
            }
            get { return _unspentPoints; }
        }

        [SerializeField] private Text UnspentPointsText;
        [SerializeField] private Image GameScreen;
        [SerializeField] private Text StatDescriptionText;

        private List<int> storedStats = new List<int>();

        public void SpendPoint(StatController stat)
        {
            UnspentPoints -= 1;
            StatDescriptionText.text = stat.Description;
        }

        public void GainPoint(StatController stat)
        {
            UnspentPoints += 1;
            StatDescriptionText.text = stat.Description;
        }

        public void RollStats()
        {
            foreach (var stat in Stats)
            {
                var roll = RollXdY(3, 6);
                stat.SetValue(roll);
            }

            UnspentPoints = 0;
        }

        public static int RollXdY(int x, int y)
        {
            int total = 0;
            for (int i = 0; i < x; i++)
            {
                total += UnityEngine.Random.Range(1, y+1);
            }
            return total;
        }

        private void Start()
        {
            RollStats();
            StoreStats();
            StatDescriptionText.text = "";
        }

        public void StoreStats()
        {
            storedStats = Stats.Select(s => s.StatValue).ToList();
        }

        public void RecallStats()
        {
            for (int i = 0; i < Stats.Count; i++)
            {
                Stats[i].SetValue(storedStats[i]);
            }
            UnspentPoints = 0;
        }

        public void PlayGame()
        {
            GameScreen.gameObject.SetActive(true);
        }

        private void Update()
        {
            if(Input.GetKeyUp(KeyCode.Escape) || Input.GetKeyUp(KeyCode.Q))
            {
                Application.Quit();
            }
        }
    }

   
}
