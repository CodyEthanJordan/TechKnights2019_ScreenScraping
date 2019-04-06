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
        }

        public void StoreStats()
        {

        }

        public void RecallStats()
        {
            throw new NotImplementedException();
        }

        private void Update()
        {
            if(Input.GetKeyUp(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
    }

   
}
