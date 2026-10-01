using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The in-run overlay: section counter, height, hull pips, the gesture hint and
// the two chrome buttons. Built at runtime inside the template's own panel body
// so nothing of the template's placeholder HUD survives underneath.
public sealed class _0xc7032d7b : MonoBehaviour
{
    private void _0xe00cf50e(RectTransform _0x71bb0811)
    {
        this._0xcc364ac5 = _0xcae6177a.Plate(_0x71bb0811, _0x32478af0._0x61e25b17(new byte[9] { 216, 217, 222, 196, 207, 216, 223, 220, 212 }, 144), this._plateSprite, _0x1c710ab2.Fade(_0x1c710ab2.BgDeep, 0.78f), 1.4f);
        _0xcae6177a.Place(this._0xcc364ac5.rectTransform, new Vector2(0.5f, 0f), new Vector2(0f, 420f), new Vector2(1020f, 180f));
        Image _0xa4c2297f = _0xcae6177a.Solid(this._0xcc364ac5.rectTransform, _0x32478af0._0x61e25b17(new byte[9] { 147, 146, 149, 143, 132, 158, 159, 156, 158 }, 219), _0x1c710ab2.Fade(_0x1c710ab2.Accent, 0.85f));
        _0xcae6177a.Place(_0xa4c2297f.rectTransform, new Vector2(0.5f, 0f), new Vector2(0f, 3f), new Vector2(1020f, 5f));
        this._0x39ae6d92 = _0xcae6177a.Label(this._0xcc364ac5.rectTransform, _0x32478af0._0x61e25b17(new byte[9] { 213, 212, 211, 201, 194, 201, 216, 197, 201 }, 157), _0x32478af0._0x61e25b17(new byte[54] { 90, 93, 94, 86, 50, 70, 93, 50, 64, 91, 65, 87, 50, 63, 50, 64, 87, 94, 87, 83, 65, 87, 50, 70, 93, 50, 81, 94, 83, 95, 66, 24, 70, 83, 66, 50, 84, 93, 64, 50, 93, 92, 87, 50, 65, 83, 84, 87, 50, 80, 93, 93, 65, 70 }, 18), 40f, _0x1c710ab2.TextPrimary, this._font, TextAlignmentOptions.Center);
        _0xcae6177a.Place(this._0x39ae6d92.rectTransform, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(980f, 144f));
    }

    private TextMeshProUGUI _0xcc13adb5;
    private TextMeshProUGUI _0x39ae6d92;
    public void _0x67f7be2f(int _0x387d682b, int _0x1044119d)
    {
        if (this._0xcc13adb5 != null)
        {
            this._0xcc13adb5.text = _0x32478af0._0x61e25b17(new byte[8] { 68, 82, 84, 67, 94, 88, 89, 55 }, 23) + _0x387d682b.ToString(_0x32478af0._0x61e25b17(new byte[2] { 96, 96 }, 80)) + _0x32478af0._0x61e25b17(new byte[3] { 131, 140, 131 }, 163) + _0x1044119d.ToString(_0x32478af0._0x61e25b17(new byte[2] { 114, 114 }, 66));
        }
    }

    private readonly List<Image> _0xa08cfb03 = new List<Image>();
    public void _0x2c9f6ade(float _0x2af1f3b3)
    {
        if (this._0x87fc226c != null)
        {
            this._0x87fc226c.text = _0x32478af0._0x61e25b17(new byte[7] { 58, 55, 59, 53, 58, 38, 82 }, 114) + _0x2af1f3b3.ToString(_0x32478af0._0x61e25b17(new byte[4] { 213, 203, 213, 213 }, 229)) + _0x32478af0._0x61e25b17(new byte[3] { 75, 32, 38 }, 107);
        }
    }

    private void _0xe7265e6e(RectTransform _0x91cd9501, int _0x93e2f230, int _0xc5cd28d0)
    {
        RectTransform _0xcd800429 = _0xcae6177a.Node(_0x91cd9501, _0x32478af0._0x61e25b17(new byte[8] { 227, 254, 231, 231, 244, 249, 228, 252 }, 171));
        _0xcae6177a.Place(_0xcd800429, new Vector2(0.5f, 1f), new Vector2(0f, -330f), new Vector2(620f, 96f));
        TextMeshProUGUI _0x045294da = _0xcae6177a.Label(_0xcd800429, _0x32478af0._0x61e25b17(new byte[12] { 155, 134, 159, 159, 140, 144, 146, 131, 135, 154, 156, 157 }, 211), _0x32478af0._0x61e25b17(new byte[4] { 11, 22, 15, 15 }, 67), 30f, _0x1c710ab2.TextMuted, this._font, TextAlignmentOptions.Right);
        _0xcae6177a.Place(_0x045294da.rectTransform, new Vector2(0.5f, 0.5f), new Vector2(-210f, 0f), new Vector2(160f, 60f));
        this._0xe5afbb18 = _0x1c710ab2.RouteAccent(_0xc5cd28d0);
        for (int _0xe90c2f65 = 0; _0xe90c2f65 < _0x93e2f230; _0xe90c2f65++)
        {
            float _0xeb39b15a = (_0xe90c2f65 - (_0x93e2f230 - 1) * 0.5f) * 100f + 46f;
            Image _0xc5c569ad = _0xcae6177a.Picture(_0xcd800429, _0x32478af0._0x61e25b17(new byte[9] { 30, 3, 26, 26, 9, 6, 31, 6, 9 }, 86) + _0xe90c2f65, this._hullPipSprite, this._0xe5afbb18);
            _0xcae6177a.Place(_0xc5c569ad.rectTransform, new Vector2(0.5f, 0.5f), new Vector2(_0xeb39b15a, 0f), new Vector2(76f, 76f));
            this._0xa08cfb03.Add(_0xc5c569ad);
        }
    }

    [SerializeField]
    private Sprite _iconBack;
    [SerializeField]
    private Sprite _hullPipSprite;
    [SerializeField]
    private Sprite _iconPause;
    private Color _0xe5afbb18 = Color.white;
    private _0x46184947 _0x69301d68;
    public void _0xfa55a1cf(float _0x17e4ac8f)
    {
        if (this._0xcc364ac5 != null)
        {
            this._0xcc364ac5.color = _0x1c710ab2.Fade(_0x1c710ab2.BgDeep, 0.78f * _0x17e4ac8f);
        }

        if (this._0x39ae6d92 != null)
        {
            this._0x39ae6d92.color = _0x1c710ab2.Fade(_0x1c710ab2.TextPrimary, _0x17e4ac8f);
        }
    }

    [SerializeField]
    private Sprite _plateSprite;
    public _0x46184947 _0x1641ab7f
    {
        get
        {
            return this._0x69301d68;
        }
    }

    // Ring outside, fill inside, icon last: the label layer is always the newest
    // sibling so a plate can never cover its own content.
    private void _0xbec46b02(RectTransform _0x1bb22c76, string _0x1ecdb289, Vector2 _0x950e23de, Vector2 _0x9bafeb9c, Sprite _0x4a290c19, System.Action _0x7fe375e2)
    {
        Image _0xdc5a5ca7 = _0xcae6177a.Plate(_0x1bb22c76, _0x1ecdb289, this._plateSprite, _0x1c710ab2.Fade(_0x1c710ab2.AccentGlow, 0.8f), 1.4f);
        _0xcae6177a.Place(_0xdc5a5ca7.rectTransform, _0x950e23de, _0x9bafeb9c, new Vector2(132f, 132f));
        Image _0x6831c22f = _0xcae6177a.Plate(_0xdc5a5ca7.rectTransform, _0x32478af0._0x61e25b17(new byte[4] { 180, 187, 190, 190 }, 242), this._plateSprite, _0x1c710ab2.Surface, 1.5f);
        _0xcae6177a.Place(_0x6831c22f.rectTransform, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(120f, 120f));
        Image _0xea4aa837 = _0xcae6177a.Picture(_0x6831c22f.rectTransform, _0x32478af0._0x61e25b17(new byte[4] { 141, 135, 139, 138 }, 196), _0x4a290c19, _0x1c710ab2.TextPrimary);
        _0xcae6177a.Place(_0xea4aa837.rectTransform, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(62f, 62f));
        _0xcae6177a.Face(_0x6831c22f, () => _0x7fe375e2.Invoke());
    }

    [SerializeField]
    private TMP_FontAsset _font;
    public void _0x9512bc4c(int _0xcbacfe8f)
    {
        for (int _0x8bd9ee32 = 0; _0x8bd9ee32 < this._0xa08cfb03.Count; _0x8bd9ee32++)
        {
            Image _0x33662a68 = this._0xa08cfb03[_0x8bd9ee32];
            if (_0x33662a68 == null)
            {
                continue;
            }

            _0x33662a68.color = _0x8bd9ee32 < _0xcbacfe8f ? this._0xe5afbb18 : _0x1c710ab2.Fade(_0x1c710ab2.Danger, 0.3f);
        }
    }

    private TextMeshProUGUI _0x87fc226c;
    private Image _0xcc364ac5;
    public void Build(Transform _0x9d8b92fd, int _0x34f763c4, int _0xf11a85b5, System.Action _0xed2dff85, System.Action _0x01706ee3)
    {
        if (_0x9d8b92fd == null)
        {
            return;
        }

        _0xcae6177a.ClearBody(_0x9d8b92fd);
        RectTransform _0x1b988ada = _0xcae6177a.Node(_0x9d8b92fd, _0x32478af0._0x61e25b17(new byte[7] { 14, 9, 18, 3, 20, 9, 24 }, 92));
        // Bottom layer: the whole panel is the drive surface. Everything added after
        // this draws on top and takes the tap first, so the chrome stays pressable.
        Image _0xcb0cd81e = _0xcae6177a.HitZone(_0x1b988ada, _0x32478af0._0x61e25b17(new byte[10] { 122, 108, 119, 104, 123, 97, 100, 113, 112, 123 }, 62));
        this._0x69301d68 = _0xcb0cd81e.gameObject.AddComponent<_0x46184947>();
        Image _0xee85ab8d = _0xcae6177a.Plate(_0x1b988ada, _0x32478af0._0x61e25b17(new byte[9] { 212, 207, 208, 223, 211, 195, 210, 201, 205 }, 128), this._plateSprite, _0x1c710ab2.Fade(_0x1c710ab2.BgDeeper, 0.78f), 1.4f);
        _0xcae6177a.Place(_0xee85ab8d.rectTransform, new Vector2(0.5f, 1f), new Vector2(0f, -178f), new Vector2(1320f, 440f));
        Image _0x641f558b = _0xcae6177a.Solid(_0x1b988ada, _0x32478af0._0x61e25b17(new byte[8] { 197, 222, 193, 206, 212, 213, 214, 212 }, 145), _0x1c710ab2.Fade(_0x1c710ab2.Accent, 0.55f));
        _0xcae6177a.Place(_0x641f558b.rectTransform, new Vector2(0.5f, 1f), new Vector2(0f, -398f), new Vector2(1242f, 4f));
        this._0xcc13adb5 = _0xcae6177a.Label(_0x1b988ada, _0x32478af0._0x61e25b17(new byte[11] { 217, 213, 217, 210, 222, 200, 206, 217, 196, 194, 195 }, 141), _0x32478af0._0x61e25b17(new byte[15] { 28, 10, 12, 27, 6, 0, 1, 111, 127, 127, 111, 96, 111, 127, 127 }, 79), 58f, _0x1c710ab2.TextPrimary, this._font, TextAlignmentOptions.Center);
        _0xcae6177a.Place(this._0xcc13adb5.rectTransform, new Vector2(0.5f, 1f), new Vector2(0f, -152f), new Vector2(560f, 96f));
        this._0x87fc226c = _0xcae6177a.Label(_0x1b988ada, _0x32478af0._0x61e25b17(new byte[10] { 110, 98, 110, 101, 114, 127, 115, 125, 114, 110 }, 58), _0x32478af0._0x61e25b17(new byte[14] { 233, 228, 232, 230, 233, 245, 129, 145, 143, 145, 145, 129, 234, 236 }, 161), 38f, _0x1c710ab2.TextMuted, this._font, TextAlignmentOptions.Center);
        _0xcae6177a.Place(this._0x87fc226c.rectTransform, new Vector2(0.5f, 1f), new Vector2(0f, -232f), new Vector2(620f, 64f));
        this._0xe7265e6e(_0x1b988ada, _0x34f763c4, _0xf11a85b5);
        this._0xbec46b02(_0x1b988ada, _0x32478af0._0x61e25b17(new byte[8] { 179, 165, 191, 174, 179, 176, 178, 186 }, 241), new Vector2(0f, 1f), new Vector2(110f, -150f), this._iconBack, _0xed2dff85);
        this._0xbec46b02(_0x1b988ada, _0x32478af0._0x61e25b17(new byte[9] { 39, 49, 43, 58, 53, 36, 48, 54, 32 }, 101), new Vector2(1f, 1f), new Vector2(-110f, -150f), this._iconPause, _0x01706ee3);
        this._0xe00cf50e(_0x1b988ada);
    }
}

internal static class _0x32478af0
{
    internal static string _0x61e25b17(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}