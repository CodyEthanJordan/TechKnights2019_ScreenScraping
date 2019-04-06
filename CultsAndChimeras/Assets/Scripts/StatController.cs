using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class StatController : MonoBehaviour
    {
        private int value = 0;

        [SerializeField] private Text valueText;

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
            if(value >= 18)
            {
                return;
            }


        }

        public void SetValue(int val)
        {
            value = val;
            valueText.text = value.ToString();
        }
    }
}
