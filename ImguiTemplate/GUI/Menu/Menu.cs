using ImGuiNET;

namespace Idk.GUI.Menu
{
    internal class Menu
    {
        public static void RenderMenu()
        {
            GUIStyle.RenderMenu();
            if (DearImGuiInjection.DearImGuiInjection.IsCursorVisible)
            {
                #region yay
                var io = ImGui.GetIO();
                var foregroundDrawList = ImGui.GetForegroundDrawList();
                float mouseSize = 15f;
                #endregion

                ImGui.Begin("ImguiTemplate");
                if (ImGui.BeginTabBar("TabsBar"))
                {
                    if (ImGui.BeginTabItem("Visuals"))
                    {
                        Visuals.RenderMenu();
                        ImGui.EndTabItem();
                    }

                    if (ImGui.BeginTabItem("Mouvements"))
                    {
                        Mouvements.RenderMenu();
                        ImGui.EndTabItem();
                    }

                    // Third Tab
                    if (ImGui.BeginTabItem("Exploits"))
                    {
                        Exploits.RenderMenu();
                        ImGui.EndTabItem();
                    }
                    if (ImGui.BeginTabItem("World Hacks"))
                    {
                        WorldHacks.RenderMenu();
                        ImGui.EndTabItem();
                    }
                    ImGui.EndTabBar();
                }
                ImGui.End();
            }
        }
    }
}
