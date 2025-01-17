﻿using AirFishLab.ScrollingList;
using UnityEngine;
using UnityEngine.UI;

namespace AirFishLab.ScrollingList.Demo
{
    public class IntListBox : ListBox
    {
        [SerializeField]
        private Text _contentText;

        protected override void UpdateDisplayContent(object content)
        {
            if(_contentText != null)
                _contentText.text = ((int) content).ToString();
        }
    }
}
