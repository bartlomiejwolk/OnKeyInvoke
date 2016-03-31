// Copyright (c) 2015 Bartlomiej Wolk (bartlomiejwolk@gmail.com)
//  
// This file is part of the OnKeyInvoke extension for Unity.
// Licensed under the MIT license. See LICENSE file in the project root folder.

using UnityEditor;

namespace OnKeyInvokeModule {

    [CustomEditor(typeof(OnKeyInvoke))]
    [CanEditMultipleObjects]
    public sealed class OnKeyInvokeEditor : Editor {

        #region FIELDS
        #endregion FIELDS

        #region UNITY MESSAGES
        #endregion UNITY MESSAGES

        #region METHODS

        [MenuItem("Component/Component Framework/OnKeyInvoke")]
        private static void AddEntryToComponentMenu() {
            if (Selection.activeGameObject != null) {
                Selection.activeGameObject.AddComponent(typeof(OnKeyInvoke));
            }
        }

        #endregion METHODS
    }

}