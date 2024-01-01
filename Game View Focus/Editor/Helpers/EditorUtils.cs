namespace GameViewFocus.Editor
{
    using UnityEngine;
    using System;
    using UnityEditor;

    /// <summary>
    /// This utility class offers a custom inspector drawer and some menu item functions.
    /// </summary>
    internal static class EditorUtils
    {
        #region GUI

        internal static void LabelBox(string text, bool fullWidth = false)
        {
            var helpBoxStyle = GUI.skin.GetStyle("HelpBox");
            helpBoxStyle.richText = true;

            EditorGUILayout.BeginHorizontal();
            if (!fullWidth) GUILayout.Space(EditorGUIUtility.labelWidth + 2);
            EditorGUILayout.SelectableLabel(text, helpBoxStyle, GUILayout.Height(EditorGUIUtility.singleLineHeight));
            EditorGUILayout.EndHorizontal();
        }

        #endregion

        #region MenuItems

        internal static void OpenGitHub()
        {
            Application.OpenURL("https://github.com/assetsbykai/GameViewFocus");
        }

        internal static void ShowAboutWindow()
        {
            var content = "Version: " + GameViewFocus.Version + " (" + GameViewFocus.CommitDate + ")\n\n" + "Thanks for using Game View Focus!\n\nPublished under MIT license\nCopyright (c) " + DateTime.Now.Year + " Kai Brueckers\n\nassetsbykai.com";
            string[] buttonPrompts = { "Honk", "Jason!", "Pay Respects", "Say Apple", "Pet the Dog", "Meow" };

            EditorUtility.DisplayDialog("Game View Focus", content, buttonPrompts[UnityEngine.Random.Range(0, buttonPrompts.Length)]);
        }

        #endregion
    }
}
