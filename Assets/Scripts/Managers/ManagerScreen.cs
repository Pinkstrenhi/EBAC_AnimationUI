using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils.Core.Singleton;

namespace Screens
{
    public class ManagerScreen : Singleton<ManagerScreen>
    {
        public List<ScreenBase> screenBases;
        public TypeScreen screenStart = TypeScreen.Panel;
        private ScreenBase _screenCurrent;

        private void Start()
        {
            HideAll();
            ShowByType(screenStart);
        }

        public void ShowByType(TypeScreen type)
        {
            if (_screenCurrent != null)
            {
                _screenCurrent.Hide();
            }
            var screenNext = screenBases.Find(i => i.typeScreen == type);
            screenNext.Show();
            _screenCurrent = screenNext;
        }

        public void HideAll()
        {
            screenBases.ForEach(i => i.Hide());
        }
    } 
}

