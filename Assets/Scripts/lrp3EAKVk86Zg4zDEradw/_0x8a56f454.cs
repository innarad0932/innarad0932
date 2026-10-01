using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0x8a56f454 : MonoBehaviour
{
    private static _0x8a56f454 _0x32eed3b3;
    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0x350d1d44)
    {
        return 0.2126f * Linear(_0x350d1d44.r) + 0.7152f * Linear(_0x350d1d44.g) + 0.0722f * Linear(_0x350d1d44.b);
    }

    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0x2cfcd9a9;
    private readonly List<TMP_Text> _0x49659793 = new List<TMP_Text>();
    private static void Fix(TMP_Text _0x98692a0c)
    {
        if (_0x98692a0c == null || !_0x98692a0c.isActiveAndEnabled)
            return;
        Material _0x2649462a = _0x98692a0c.fontSharedMaterial;
        if (_0x2649462a == null || !_0x2649462a.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0x2649462a.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0x2649462a.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0xdfb77bec = _0x98692a0c.color;
        if (_0xdfb77bec.a <= 0f)
            return;
        Color _0x22facc19 = _0x2649462a.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0xdfb77bec, _0x22facc19) >= MinRatio)
            return;
        Color _0x849b46cb = Luminance(_0x22facc19) < 0.5f ? Color.white : Color.black;
        Color _0x6016e893;
        if (Ratio(_0x849b46cb, _0x22facc19) < TargetRatio)
        {
            _0x6016e893 = _0x849b46cb;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0x485cfe68 = 0f;
            float _0x4309509f = 1f;
            for (int _0xf4a971f1 = 0; _0xf4a971f1 < 20; _0xf4a971f1++)
            {
                float _0xe9b03094 = (_0x485cfe68 + _0x4309509f) * 0.5f;
                if (Ratio(Color.Lerp(_0xdfb77bec, _0x849b46cb, _0xe9b03094), _0x22facc19) >= TargetRatio)
                    _0x4309509f = _0xe9b03094;
                else
                    _0x485cfe68 = _0xe9b03094;
            }

            _0x6016e893 = Color.Lerp(_0xdfb77bec, _0x849b46cb, _0x4309509f);
        }

        _0x6016e893.a = _0xdfb77bec.a;
        _0x98692a0c.color = _0x6016e893;
    }

    private const float MinOutlineWidth = 0.01f;
    private const float TargetRatio = 7f;
    private readonly HashSet<TMP_Text> _0x6222c59b = new HashSet<TMP_Text>();
    private static float Linear(float _0x8b1bfe0f)
    {
        _0x8b1bfe0f = Mathf.Clamp01(_0x8b1bfe0f);
        return _0x8b1bfe0f <= 0.03928f ? _0x8b1bfe0f / 12.92f : Mathf.Pow((_0x8b1bfe0f + 0.055f) / 1.055f, 2.4f);
    }

    private void OnDisable()
    {
        if (this._0x2cfcd9a9 != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0x2cfcd9a9);
    }

    private static float Ratio(Color _0x0c13796c, Color _0x2e9fcfde)
    {
        float _0x4509a57a = Luminance(_0x0c13796c);
        float _0xa0b5aec9 = Luminance(_0x2e9fcfde);
        return (Mathf.Max(_0x4509a57a, _0xa0b5aec9) + 0.05f) / (Mathf.Min(_0x4509a57a, _0xa0b5aec9) + 0.05f);
    }

    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0xa0c5eac9(Object _0xfae89054)
    {
        TMP_Text _0xce293773 = _0xfae89054 as TMP_Text;
        if (_0xce293773 != null)
            this._0x6222c59b.Add(_0xce293773);
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x32eed3b3 != null)
            return;
        GameObject _0xe46a9752 = new GameObject(_0x3f1dbdef._0xad9ce3c3(new byte[16] { 38, 31, 2, 49, 29, 28, 6, 0, 19, 1, 6, 53, 7, 19, 0, 22 }, 114));
        _0xe46a9752.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0xe46a9752);
        _0x32eed3b3 = _0xe46a9752.AddComponent<_0x8a56f454>();
    }

    private void LateUpdate()
    {
        if (this._0x6222c59b.Count == 0)
            return;
        this._0x49659793.Clear();
        this._0x49659793.AddRange(this._0x6222c59b);
        this._0x6222c59b.Clear();
        for (int _0xfc8920b3 = 0; _0xfc8920b3 < this._0x49659793.Count; _0xfc8920b3++)
            Fix(this._0x49659793[_0xfc8920b3]);
    }

    private void OnEnable()
    {
        if (this._0x2cfcd9a9 == null)
            this._0x2cfcd9a9 = _0x19aebfb7 => this._0xa0c5eac9(_0x19aebfb7);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0x2cfcd9a9);
    }

    private const float MinRatio = 4.5f;
}

internal static class _0x3f1dbdef
{
    internal static string _0xad9ce3c3(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}