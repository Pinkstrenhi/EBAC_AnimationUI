using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Screens
{
    public class ScreenHelper : MonoBehaviour
    {
        public TypeScreen typeScreen;

        public void OnClick()
        {
            ManagerScreen.Instance.ShowByType(typeScreen);
        }
    }
}
