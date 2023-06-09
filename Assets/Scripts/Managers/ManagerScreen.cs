using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils.Core.Singleton;
using Random = UnityEngine.Random;

namespace Screens
{
    public class ManagerScreen : Singleton<ManagerScreen>
    {
        public List<ScreenBase> screenBases;
        public TypeScreen screenStart = TypeScreen.Panel;
        private ScreenBase _screenCurrent;

        public Vector3 extensionsVectorTest;
        public List<GameObject> extensionsListObjectsTest;
        private void Start()
        {
            //transform.Scale(2f);
            //gameObject.ScaleGameObject(2f);
            //extensionsVectorTest.ScaleVector(2f);
            screenBases.GetRandom();
            //extensionsListObjectsTest.GetRandom();
            HideAll();
            ShowByType(screenStart);
        }

        /*public void Scale(Transform scaleTransform, float scaleSize = 1.2f)
        {
            scaleTransform.localScale = Vector3.one * scaleSize; 
        }*/
        /*private void GetRandom()
        {
            screenBases[Random.Range(0, screenBases.Count)].durationAnimation = 1f;
        }*/
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

