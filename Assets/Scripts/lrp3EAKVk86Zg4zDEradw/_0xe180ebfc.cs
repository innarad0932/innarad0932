using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The route sheet. All three shafts are open from the first launch, because a
// card that cannot be pressed is a button with no visible answer. Picking one
// changes three things at once: the card's own frame, a punch on the card, and
// the live preview plus objective line behind the sheet.
public sealed class _0xe180ebfc : MonoBehaviour
{
    // Three simultaneous signals for one tap: frame, fill and the record column.
    public void _0x4d88ed58()
    {
        int _0x05c6e3f7 = _0xe8c9d026._0x815ca20b;
        for (int _0xf4337df4 = 0; _0xf4337df4 < this._0x2bf3413c.Count; _0xf4337df4++)
        {
            Color _0x9bfc2cb2 = _0x1c710ab2.RouteAccent(_0xf4337df4);
            bool _0x0f6654fc = _0xf4337df4 == _0x05c6e3f7;
            if (this._0x2bf3413c[_0xf4337df4] != null)
            {
                this._0x2bf3413c[_0xf4337df4].color = _0x0f6654fc ? _0x9bfc2cb2 : _0x1c710ab2.Fade(_0x1c710ab2.AccentGlow, 0.28f);
            }

            if (this._0x9ef91dcb[_0xf4337df4] != null)
            {
                this._0x9ef91dcb[_0xf4337df4].color = _0x0f6654fc ? Color.Lerp(_0x1c710ab2.Surface, _0x9bfc2cb2, 0.22f) : _0x1c710ab2.Surface;
            }

            if (this._0xa0c9f6c1[_0xf4337df4] != null)
            {
                this._0xa0c9f6c1[_0xf4337df4].text = _0xe8c9d026.BestOf(_0xf4337df4).ToString();
            }
        }

        if (this._0x8d18c1e9 != null)
        {
            this._0x8d18c1e9.SetActive(this._0x2bf3413c.Count == 0);
        }
    }

    public void _0xf9cbc5e1()
    {
        if (this._0xd29bf640 != null)
        {
            this._0xd29bf640.gameObject.SetActive(false);
        }
    }

    private readonly List<Image> _0x9ef91dcb = new List<Image>();
    private void _0xba23c981()
    {
        Image _0x97501232 = _0xcae6177a.Plate(this._0xd29bf640, _0x9a8b1121._0x26e310e5(new byte[12] { 182, 171, 177, 176, 161, 183, 187, 167, 168, 171, 183, 161 }, 228), this._plateSprite, _0x1c710ab2.Fade(_0x1c710ab2.AccentGlow, 0.8f), 1.4f);
        _0xcae6177a.Place(_0x97501232.rectTransform, new Vector2(0.5f, 0.17f), Vector2.zero, new Vector2(430f, 132f));
        Image _0x1604a4d6 = _0xcae6177a.Plate(_0x97501232.rectTransform, _0x9a8b1121._0x26e310e5(new byte[4] { 189, 178, 183, 183 }, 251), this._plateSprite, _0x1c710ab2.Surface, 1.5f);
        _0xcae6177a.Place(_0x1604a4d6.rectTransform, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(420f, 122f));
        Image _0x158e80f7 = _0xcae6177a.Picture(_0x1604a4d6.rectTransform, _0x9a8b1121._0x26e310e5(new byte[4] { 157, 151, 155, 154 }, 212), this._iconClose, _0x1c710ab2.TextPrimary);
        _0xcae6177a.Place(_0x158e80f7.rectTransform, new Vector2(0.5f, 0.5f), new Vector2(-116f, 0f), new Vector2(44f, 44f));
        TextMeshProUGUI _0x34e82fa0 = _0xcae6177a.Label(_0x1604a4d6.rectTransform, _0x9a8b1121._0x26e310e5(new byte[5] { 64, 77, 78, 73, 64 }, 12), _0x9a8b1121._0x26e310e5(new byte[5] { 118, 121, 122, 102, 112 }, 53), 48f, _0x1c710ab2.TextPrimary, this._font, TextAlignmentOptions.Center);
        _0xcae6177a.Place(_0x34e82fa0.rectTransform, new Vector2(0.5f, 0.5f), new Vector2(26f, 0f), new Vector2(300f, 100f));
        _0xcae6177a.Face(_0x1604a4d6, () => this._0xf9cbc5e1());
    }

    private void _0x3fcab2ab(RectTransform _0x4933d04a, int _0xbe7cb31c)
    {
        Color _0xa8d4dc0b = _0x1c710ab2.RouteAccent(_0xbe7cb31c);
        float _0x310ee8ff = 300f - _0xbe7cb31c * 300f;
        Image _0x890bb71f = _0xcae6177a.Plate(_0x4933d04a, _0x9a8b1121._0x26e310e5(new byte[11] { 51, 46, 52, 53, 36, 62, 34, 32, 51, 37, 62 }, 97) + _0xbe7cb31c, this._plateSprite, _0x1c710ab2.Fade(_0xa8d4dc0b, 0.9f), 1.4f);
        _0xcae6177a.Place(_0x890bb71f.rectTransform, new Vector2(0.5f, 0.5f), new Vector2(0f, _0x310ee8ff), new Vector2(944f, 264f));
        Image _0x59e0b0ba = _0xcae6177a.Plate(_0x890bb71f.rectTransform, _0x9a8b1121._0x26e310e5(new byte[4] { 116, 123, 126, 126 }, 50), this._plateSprite, _0x1c710ab2.Surface, 1.5f);
        _0xcae6177a.Place(_0x59e0b0ba.rectTransform, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(936f, 256f));
        TextMeshProUGUI _0x7aaed072 = _0xcae6177a.Label(_0x59e0b0ba.rectTransform, _0x9a8b1121._0x26e310e5(new byte[4] { 13, 2, 14, 6 }, 67), _0xe8c9d026.NameOf(_0xbe7cb31c), 54f, _0x1c710ab2.TextPrimary, this._font, TextAlignmentOptions.Left);
        _0xcae6177a.Place(_0x7aaed072.rectTransform, new Vector2(0f, 1f), new Vector2(330f, -66f), new Vector2(600f, 70f));
        TextMeshProUGUI _0x2197a07c = _0xcae6177a.Label(_0x59e0b0ba.rectTransform, _0x9a8b1121._0x26e310e5(new byte[8] { 173, 187, 189, 170, 183, 177, 176, 173 }, 254), _0xe8c9d026.SectionsOf(_0xbe7cb31c) + _0x9a8b1121._0x26e310e5(new byte[9] { 65, 50, 36, 34, 53, 40, 46, 47, 50 }, 97), 38f, _0x1c710ab2.TextMuted, this._font, TextAlignmentOptions.Left);
        _0xcae6177a.Place(_0x2197a07c.rectTransform, new Vector2(0f, 1f), new Vector2(330f, -134f), new Vector2(600f, 56f));
        TextMeshProUGUI _0x81ebc0ae = _0xcae6177a.Label(_0x59e0b0ba.rectTransform, _0x9a8b1121._0x26e310e5(new byte[5] { 108, 107, 111, 99, 125 }, 46), _0xe8c9d026.BeamsOf(_0xbe7cb31c), 38f, _0x1c710ab2.Fade(_0xa8d4dc0b, 1f), this._font, TextAlignmentOptions.Left);
        _0xcae6177a.Place(_0x81ebc0ae.rectTransform, new Vector2(0f, 1f), new Vector2(330f, -192f), new Vector2(600f, 56f));
        TextMeshProUGUI _0x188f9a9e = _0xcae6177a.Label(_0x59e0b0ba.rectTransform, _0x9a8b1121._0x26e310e5(new byte[12] { 163, 164, 178, 181, 190, 162, 160, 177, 181, 168, 174, 175 }, 225), _0x9a8b1121._0x26e310e5(new byte[4] { 108, 107, 125, 122 }, 46), 28f, _0x1c710ab2.TextMuted, this._font, TextAlignmentOptions.Center);
        _0xcae6177a.Place(_0x188f9a9e.rectTransform, new Vector2(1f, 0.5f), new Vector2(-116f, 42f), new Vector2(180f, 44f));
        TextMeshProUGUI _0x000c8ca2 = _0xcae6177a.Label(_0x59e0b0ba.rectTransform, _0x9a8b1121._0x26e310e5(new byte[10] { 77, 74, 92, 91, 80, 89, 78, 67, 90, 74 }, 15), _0xe8c9d026.BestOf(_0xbe7cb31c).ToString(), 52f, _0x1c710ab2.Gold, this._font, TextAlignmentOptions.Center);
        _0xcae6177a.Place(_0x000c8ca2.rectTransform, new Vector2(1f, 0.5f), new Vector2(-116f, -22f), new Vector2(180f, 70f));
        int _0xc82473fd = _0xbe7cb31c;
        _0xcae6177a.Face(_0x59e0b0ba, () => this._0x56c1a432(_0xc82473fd));
        this._0x2bf3413c.Add(_0x890bb71f);
        this._0x9ef91dcb.Add(_0x59e0b0ba);
        this._0xa0c9f6c1.Add(_0x000c8ca2);
    }

    public void Build(RectTransform _0xfd89162a, System.Action<int> _0xdca4681d)
    {
        this._0x02bcf212 = _0xdca4681d;
        this._0xd29bf640 = _0xcae6177a.Node(_0xfd89162a, _0x9a8b1121._0x26e310e5(new byte[14] { 141, 144, 138, 139, 154, 140, 128, 144, 137, 154, 141, 147, 158, 134 }, 223));
        Image _0xfa45bc43 = _0xcae6177a.Solid(this._0xd29bf640, _0x9a8b1121._0x26e310e5(new byte[5] { 157, 134, 143, 138, 139 }, 206), _0x1c710ab2.Fade(_0x1c710ab2.BgDeeper, 0.88f));
        _0xcae6177a.Stretch(_0xfa45bc43.rectTransform);
        _0xfa45bc43.raycastTarget = true;
        TextMeshProUGUI _0x71499e1a = _0xcae6177a.Label(this._0xd29bf640, _0x9a8b1121._0x26e310e5(new byte[12] { 185, 164, 190, 191, 174, 184, 180, 191, 162, 191, 167, 174 }, 235), _0x9a8b1121._0x26e310e5(new byte[6] { 248, 229, 255, 254, 239, 249 }, 170), 72f, _0x1c710ab2.TextPrimary, this._font, TextAlignmentOptions.Center);
        _0xcae6177a.Place(_0x71499e1a.rectTransform, new Vector2(0.5f, 0.88f), Vector2.zero, new Vector2(900f, 120f));
        TextMeshProUGUI _0xbc3a3f91 = _0xcae6177a.Label(this._0xd29bf640, _0x9a8b1121._0x26e310e5(new byte[10] { 113, 108, 118, 119, 102, 112, 124, 112, 118, 97 }, 35), _0x9a8b1121._0x26e310e5(new byte[14] { 136, 158, 151, 158, 152, 143, 251, 154, 251, 136, 147, 154, 157, 143 }, 219), 34f, _0x1c710ab2.TextMuted, this._font, TextAlignmentOptions.Center);
        _0xcae6177a.Place(_0xbc3a3f91.rectTransform, new Vector2(0.5f, 0.823f), Vector2.zero, new Vector2(900f, 60f));
        RectTransform _0x88bbb405 = _0xcae6177a.Node(this._0xd29bf640, _0x9a8b1121._0x26e310e5(new byte[10] { 147, 142, 148, 149, 132, 158, 147, 128, 130, 138 }, 193));
        _0xcae6177a.Place(_0x88bbb405, new Vector2(0.5f, 0.56f), Vector2.zero, new Vector2(980f, 900f));
        for (int _0x5f9d392c = 0; _0x5f9d392c < _0xe8c9d026.Count; _0x5f9d392c++)
        {
            this._0x3fcab2ab(_0x88bbb405, _0x5f9d392c);
        }

        this._0x8d18c1e9 = _0xcae6177a.Label(_0x88bbb405, _0x9a8b1121._0x26e310e5(new byte[12] { 115, 110, 116, 117, 100, 114, 126, 100, 108, 113, 117, 120 }, 33), _0x9a8b1121._0x26e310e5(new byte[19] { 209, 208, 191, 205, 208, 202, 203, 218, 204, 191, 222, 201, 222, 214, 211, 222, 221, 211, 218 }, 159), 40f, _0x1c710ab2.TextMuted, this._font, TextAlignmentOptions.Center).gameObject;
        _0xcae6177a.Place(this._0x8d18c1e9.GetComponent<RectTransform>(), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(900f, 120f));
        this._0x8d18c1e9.SetActive(this._0x2bf3413c.Count == 0);
        this._0xba23c981();
        this._0xd29bf640.gameObject.SetActive(false);
    }

    public void _0x18ea04b4()
    {
        if (this._0xd29bf640 == null)
        {
            return;
        }

        this._0xd29bf640.gameObject.SetActive(true);
        this._0xd29bf640.SetAsLastSibling();
        this._0x4d88ed58();
    }

    private readonly List<Image> _0x2bf3413c = new List<Image>();
    private RectTransform _0xd29bf640;
    [SerializeField]
    private Sprite _plateSprite;
    [SerializeField]
    private Sprite _iconClose;
    private readonly List<TextMeshProUGUI> _0xa0c9f6c1 = new List<TextMeshProUGUI>();
    [SerializeField]
    private TMP_FontAsset _font;
    private void _0x56c1a432(int _0x1766f4ab)
    {
        _0xe8c9d026._0x815ca20b = _0x1766f4ab;
        this._0x4d88ed58();
        if (_0x1766f4ab >= 0 && _0x1766f4ab < this._0x2bf3413c.Count && this._0x2bf3413c[_0x1766f4ab] != null)
        {
            Transform _0x5acb0ef7 = this._0x2bf3413c[_0x1766f4ab].transform;
            DOTween.Kill(_0x5acb0ef7);
            _0x5acb0ef7.DOPunchScale(Vector3.one * 0.06f, 0.25f, 6, 0.6f);
        }

        if (this._0x02bcf212 != null)
        {
            this._0x02bcf212.Invoke(_0x1766f4ab);
        }
    }

    private GameObject _0x8d18c1e9;
    private System.Action<int> _0x02bcf212;
    public bool _0x8b91f4ba
    {
        get
        {
            return this._0xd29bf640 != null && this._0xd29bf640.gameObject.activeSelf;
        }
    }
}

internal static class _0x9a8b1121
{
    internal static string _0x26e310e5(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}