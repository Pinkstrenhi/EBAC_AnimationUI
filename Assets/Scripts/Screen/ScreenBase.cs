using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;
using DG.Tweening;

namespace Screens
{
    public enum TypeScreen
    {
        Panel,
        PanelInfo,
        PanelShop
    }
    public class ScreenBase : MonoBehaviour
    {
        public TypeScreen typeScreen;
        public List<Transform> objects;
        public List<Typper> phrases;
        public bool startHided = false;
        [Header("Animation")] 
            public float timeBetweenObjects = 0.05f;
            public float durationAnimation = 0.2f;
        private void Start()
        {
            if (startHided)
            {
                HideObjects();
            }
            else
            {
                ForceShowObjects();
            }
        }
        #region Buttons

            [Button]
            protected virtual void Show()
            {
                ShowObjects();
                Debug.Log("Show");
            }
            [Button]
            protected virtual void Hide()
            {
                HideObjects();
                Debug.Log("Hide");
            }

        #endregion
        
        #region Show

            private void ShowObjects()
            {
                for (var i = 0; i < objects.Count; i++)
                {
                    var objectListed = objects[i];
                    objectListed.gameObject.SetActive(true);
                    objectListed.DOScale(0,durationAnimation).From().SetDelay(i * timeBetweenObjects);
                }
                Invoke(nameof(StartType),timeBetweenObjects * objects.Count);
            }
            private void ForceShowObjects()
            {
                objects.ForEach(i => i.gameObject.SetActive(true));
            }

        #endregion

        #region Hide

            private void HideObjects()
            {
                objects.ForEach(i => i.gameObject.SetActive(false));
            }

        #endregion

        #region Typper

            public void StartType()
            {
                for (var i = 0; i < phrases.Count; i++)
                {
                    phrases[i].StartType();
                }
            }

        #endregion
    }
}
