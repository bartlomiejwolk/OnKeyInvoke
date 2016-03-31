// Copyright (c) 2015 Bartlomiej Wolk (bartlomiejwolk@gmail.com)
//  
// This file is part of the OnKeyInvoke extension for Unity.
// Licensed under the MIT license. See LICENSE file in the project root folder.

using UnityEngine;
using UnityEngine.Events;

namespace OnKeyInvokeModule {

    public sealed class OnKeyInvoke : MonoBehaviour {

        #region CONSTANTS

        public const string Version = "v0.1.0";
        public const string Extension = "OnKeyInvoke";
        public const string Description = "";

        #endregion CONSTANTS

        #region DELEGATES
        #endregion DELEGATES

        #region EVENTS
        #endregion EVENTS

        #region FIELDS

#pragma warning disable 0414
        /// <summary>
        ///     Allows identify component in the scene file when reading it with
        ///     text editor.
        /// </summary>
        [SerializeField]
        [HideInInspector]
        private string componentName = "OnKeyInvoke";
#pragma warning restore 0414

        #endregion FIELDS

        #region INSPECTOR FIELDS

        [SerializeField]
        private string comment = "Comment";

        [SerializeField]
        private KeyCode shortcutKey;

        [SerializeField]
        private UnityEvent callbacks;

        #endregion INSPECTOR FIELDS

        #region PROPERTIES

        /// <summary>
        ///     Optional text to describe purpose of this instance of the component.
        /// </summary>
        public string Comment {
            get { return comment; }
            set { comment = value; }
        }

        public KeyCode ShortcutKey {
            get { return shortcutKey; }
            set { shortcutKey = value; }
        }

        public UnityEvent Callbacks {
            get { return callbacks; }
            set { callbacks = value; }
        }

        #endregion PROPERTIES

        #region UNITY MESSAGES

        private void Awake() { }

        private void FixedUpdate() { }

        private void LateUpdate() { }

        private void OnEnable() { }

        private void Reset() { }

        private void Start() { }

        private void Update() {
            HandleKeyShortcut();
        }
        private void OnValidate() { }

        private void OnDisable() { }

        private void OnDestroy() { }

        #endregion UNITY MESSAGES

        #region EVENT INVOCATORS
        #endregion INVOCATORS

        #region EVENT HANDLERS
        #endregion EVENT HANDLERS

        #region METHODS

        private void HandleKeyShortcut() {
            if (!Input.GetKeyDown(ShortcutKey)) {
                return;
            }

            Callbacks.Invoke();
        }

        #endregion METHODS

    }

}