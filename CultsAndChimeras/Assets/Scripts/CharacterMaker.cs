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
        public int UnspentPoints { private set; get; }

        public void SpendPoint()
        {
            UnspentPoints -= 1;
            //TODO: update UI
        }

        public void RollStats()
        {
            foreach (var stat in Stats)
            {
                var roll = RollXdY(3, 6);
                stat.SetValue(roll);
            }
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
    }

   
}
