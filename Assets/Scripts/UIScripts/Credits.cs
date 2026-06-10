using UnityEngine;

namespace UIScripts
{
    public static class Credits
    {
        public static readonly string Authors = "Mustafa Demirsoy & Ali Mert Vural";
        public static readonly string GameTitle = "2D TOP DOWN GAME";

        private static GUIStyle style;

        public static void DrawPauseCredits()
        {
            if (style == null)
            {
                style = new GUIStyle(GUI.skin.label)
                {
                    fontSize = 16,
                    fontStyle = FontStyle.Bold,
                    alignment = TextAnchor.LowerCenter
                };
            }

            string label = GameTitle + "\n" + Authors;

            Rect shadowRect = new Rect(1, Screen.height - 59, Screen.width, 56);
            Rect textRect = new Rect(0, Screen.height - 60, Screen.width, 56);

            Color old = GUI.color;
            GUI.color = new Color(0f, 0f, 0f, 0.7f);
            GUI.Label(shadowRect, label, style);
            GUI.color = new Color(1f, 1f, 1f, 0.9f);
            GUI.Label(textRect, label, style);
            GUI.color = old;
        }
    }
}
