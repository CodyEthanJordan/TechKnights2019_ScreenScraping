using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class StatController : MonoBehaviour
    {
        private int _statValue = 0;
        public int StatValue
        {
            private set
            {
                _statValue = value;
                valueText.text = _statValue.ToString();
            }
            get
            {
                return _statValue;
            }
        }

        [SerializeField] private Text valueText;
        [SerializeField] private CharacterMaker cm;

        private void Awake()
        {
            
        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void Increase()
        {
            if(StatValue >= 18)
            {
                return; //can't go above an 18
            }

            if(cm.UnspentPoints <= 0)
            {
                return; //can't spend points you don't have
            }

            cm.SpendPoint();
            StatValue += 1;
        }

        public void Decrease()
        {
            if(StatValue <= 3)
            {
                return; //minimum value is 3
            }

            cm.GainPoint();
            StatValue -= 1;
        }

        public void SetValue(int val)
        {
            StatValue = val;
        }
    }
}
