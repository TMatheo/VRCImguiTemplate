using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using Idk.GUI;
using UnityEngine;

namespace Idk
{
    [BepInPlugin("AuthorName", "PluginName", "1.0")]
    public class Main : BasePlugin
    {
        internal static new ManualLogSource Log;
        public override void Load()
        {
            Log = base.Log;
            AddComponent<MonoBeh>();
        }
    }
}
internal class MonoBeh : MonoBehaviour
{
    void OnEnable()
    {
        DearImGuiInjection.DearImGuiInjection.Render += Rendering.RenderGui;
    }
}
