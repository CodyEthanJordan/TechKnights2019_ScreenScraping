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

        private List<int> storedStats = new List<int>();

        public void SpendPoint()
        {
            UnspentPoints -= 1;
        }

        public void GainPoint()
        {
            UnspentPoints += 1;
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
                total += UnityEngine.Random.Range(1, y);
            }
            return total;
        }

        private void Start()
        {
            RollStats();
            StoreStats();
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
