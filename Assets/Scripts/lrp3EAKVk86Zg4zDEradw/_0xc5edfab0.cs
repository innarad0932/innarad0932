using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Owns the three result cards. Each pop keeps the template's frame and animation
// but none of its content: every child of the pop body is switched off once and a
// card built for this game takes its place, so no template wording, no grey
// placeholder and no empty close-button square can reach the screen.
public sealed class _0xc5edfab0 : MonoBehaviour
{
    public void _0x2596b9ca(bool _0x915c9774, int _0x79f78e60, int _0x74d95f1b, int _0x37a2cfca)
    {
        _0x673f471c _0x196421e3 = _0xf905b1bd.Instance._0x399c969a(_0xcb53ffe7._0x8436a0ff.LOSE);
        if (_0x196421e3 == null || _0x196421e3.Content == null)
        {
            return;
        }

        if (this._0x1032fbd9 == null)
        {
            RectTransform _0x391a6e1d = this._0xfc6a68bc(_0x196421e3, _0x1c710ab2.Danger);
            this._0x2c5f05b9(_0x391a6e1d, this._containerSprite, _0x1c710ab2.Danger);
            this._0x1032fbd9 = this._0x0447f475(_0x391a6e1d, _0xade90d97._0xd8a8591a(new byte[13] { 17, 12, 21, 21, 121, 27, 11, 28, 24, 26, 17, 28, 29 }, 89), _0x1c710ab2.Danger);
            this._0x6e69bedc = this._0x53983847(_0x391a6e1d, _0xade90d97._0xd8a8591a(new byte[15] { 57, 47, 41, 62, 35, 37, 36, 74, 90, 90, 74, 69, 74, 90, 90 }, 106));
            this._0x3bd38a72 = this._0xa7b72357(_0x391a6e1d, _0xade90d97._0xd8a8591a(new byte[15] { 76, 75, 93, 90, 46, 62, 46, 93, 75, 77, 90, 71, 65, 64, 93 }, 14));
            this._0x47e4d5f3(_0x391a6e1d, _0xade90d97._0xd8a8591a(new byte[5] { 63, 40, 57, 63, 52 }, 109), _0xade90d97._0xd8a8591a(new byte[10] { 214, 205, 196, 195, 209, 165, 200, 192, 203, 208 }, 133), _0x1c710ab2.Danger);
            this._0x98d1ce33(_0x391a6e1d, _0x1c710ab2.Danger, () => _0xbecc5006.Instance.LoadSceneByIndex(_0xcb53ffe7._0xd8635e47.SCENE_0));
        }

        this._0x1032fbd9.text = _0x915c9774 ? _0xade90d97._0xd8a8591a(new byte[13] { 64, 93, 68, 68, 40, 74, 90, 77, 73, 75, 64, 77, 76 }, 8) : _0xade90d97._0xd8a8591a(new byte[25] { 66, 70, 80, 93, 93, 94, 70, 84, 85, 49, 83, 72, 27, 69, 89, 84, 49, 82, 94, 93, 93, 80, 65, 66, 84 }, 17);
        this._0x6e69bedc.text = _0xade90d97._0xd8a8591a(new byte[8] { 238, 248, 254, 233, 244, 242, 243, 157 }, 189) + _0x79f78e60.ToString(_0xade90d97._0xd8a8591a(new byte[2] { 228, 228 }, 212)) + _0xade90d97._0xd8a8591a(new byte[3] { 42, 37, 42 }, 10) + _0x74d95f1b.ToString(_0xade90d97._0xd8a8591a(new byte[2] { 8, 8 }, 56));
        this._0x3bd38a72.text = _0xade90d97._0xd8a8591a(new byte[5] { 156, 155, 141, 138, 254 }, 222) + _0x37a2cfca + _0xade90d97._0xd8a8591a(new byte[9] { 206, 189, 171, 173, 186, 167, 161, 160, 189 }, 238);
        this._0xa3ccfc60(_0x196421e3);
        _0xf905b1bd.Instance._0x6698f986(_0xcb53ffe7._0x8436a0ff.LOSE);
    }

    private TextMeshProUGUI _0x6e69bedc;
    [SerializeField]
    private Sprite _containerSprite;
    private void _0x4f8040e2(RectTransform _0xb1f0ac47)
    {
        this._0xb5d62ce5(_0xb1f0ac47, _0xade90d97._0xd8a8591a(new byte[10] { 100, 114, 104, 121, 116, 99, 117, 115, 107, 99 }, 38), _0xade90d97._0xd8a8591a(new byte[6] { 240, 231, 241, 247, 239, 231 }, 162), new Vector2(0f, -880f), _0x1c710ab2.Accent, true, () => this._0x490be34e());
        this._0xb5d62ce5(_0xb1f0ac47, _0xade90d97._0xd8a8591a(new byte[9] { 21, 3, 25, 8, 5, 18, 3, 5, 14 }, 87), _0xade90d97._0xd8a8591a(new byte[5] { 92, 75, 90, 92, 87 }, 14), new Vector2(-250f, -1020f), _0x1c710ab2.Accent, false, () => _0xbecc5006.Instance._0x2d4438f7());
        this._0xb5d62ce5(_0xb1f0ac47, _0xade90d97._0xd8a8591a(new byte[8] { 115, 101, 127, 110, 124, 116, 127, 100 }, 49), _0xade90d97._0xd8a8591a(new byte[10] { 170, 177, 184, 191, 173, 217, 180, 188, 183, 172 }, 249), new Vector2(250f, -1020f), _0x1c710ab2.Accent, false, () => _0xbecc5006.Instance.LoadSceneByIndex(_0xcb53ffe7._0xd8635e47.SCENE_0));
    }

    public void _0x93815cd3(int _0x942c6f11, int _0x7ff91c70, int _0x040681df, int _0xf63304dd, System.Action _0x4e488b7d)
    {
        this._0x6fd19cd1 = _0x4e488b7d;
        _0x673f471c _0x19e17277 = _0xf905b1bd.Instance._0x399c969a(_0xcb53ffe7._0x8436a0ff.PAUSE);
        if (_0x19e17277 == null || _0x19e17277.Content == null)
        {
            return;
        }

        if (this._0xe51604d3 == null)
        {
            RectTransform _0x52ab6142 = this._0xfc6a68bc(_0x19e17277, _0x1c710ab2.Accent);
            this._0x2c5f05b9(_0x52ab6142, this._containerSprite, _0x1c710ab2.Accent);
            this._0xe51604d3 = this._0x0447f475(_0x52ab6142, _0xade90d97._0xd8a8591a(new byte[13] { 110, 105, 106, 98, 6, 118, 105, 117, 111, 114, 111, 105, 104 }, 38), _0x1c710ab2.Accent);
            this._0x3c5991b8 = this._0x53983847(_0x52ab6142, _0xade90d97._0xd8a8591a(new byte[15] { 250, 236, 234, 253, 224, 230, 231, 137, 153, 153, 137, 134, 137, 153, 153 }, 169));
            this._0x195bf519 = this._0xa7b72357(_0x52ab6142, _0xade90d97._0xd8a8591a(new byte[10] { 129, 156, 133, 133, 233, 249, 233, 230, 233, 249 }, 201));
            this._0x4f8040e2(_0x52ab6142);
            this._0x98d1ce33(_0x52ab6142, _0x1c710ab2.Accent, () => this._0x490be34e());
        }

        this._0x3c5991b8.text = _0xade90d97._0xd8a8591a(new byte[8] { 24, 14, 8, 31, 2, 4, 5, 107 }, 75) + _0x942c6f11.ToString(_0xade90d97._0xd8a8591a(new byte[2] { 187, 187 }, 139)) + _0xade90d97._0xd8a8591a(new byte[3] { 240, 255, 240 }, 208) + _0x7ff91c70.ToString(_0xade90d97._0xd8a8591a(new byte[2] { 255, 255 }, 207));
        this._0x195bf519.text = _0xade90d97._0xd8a8591a(new byte[5] { 211, 206, 215, 215, 187 }, 155) + _0x040681df + _0xade90d97._0xd8a8591a(new byte[3] { 119, 120, 119 }, 87) + _0xf63304dd;
        this._0xa3ccfc60(_0x19e17277);
        _0xf905b1bd.Instance._0x6698f986(_0xcb53ffe7._0x8436a0ff.PAUSE);
    }

    private void _0xb5d62ce5(RectTransform _0x6b337898, string _0x5ce78069, string _0xd4c72b6d, Vector2 _0xc0dad1f2, Color _0xcc43634c, bool _0x20479785, System.Action _0x9d28afe5)
    {
        float width = _0x20479785 ? 720f : 460f;
        Image _0x74566ec4 = _0xcae6177a.Plate(_0x6b337898, _0x5ce78069, this._plateSprite, _0x1c710ab2.Fade(_0x20479785 ? _0xcc43634c : _0x1c710ab2.AccentGlow, _0x20479785 ? 1f : 0.7f), 1.4f);
        _0xcae6177a.Place(_0x74566ec4.rectTransform, new Vector2(0.5f, 1f), _0xc0dad1f2, new Vector2(width, 132f));
        Image _0x99fb18ff = _0xcae6177a.Plate(_0x74566ec4.rectTransform, _0xade90d97._0xd8a8591a(new byte[4] { 238, 225, 228, 228 }, 168), this._plateSprite, _0x20479785 ? _0x1c710ab2.Fade(_0xcc43634c, 0.24f) : _0x1c710ab2.Surface, 1.5f);
        _0xcae6177a.Place(_0x99fb18ff.rectTransform, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(width - 10f, 122f));
        TextMeshProUGUI _0x13ba9126 = _0xcae6177a.Label(_0x99fb18ff.rectTransform, _0xade90d97._0xd8a8591a(new byte[5] { 165, 168, 171, 172, 165 }, 233), _0xd4c72b6d, 48f, _0x1c710ab2.TextPrimary, this._font, TextAlignmentOptions.Center);
        _0xcae6177a.Place(_0x13ba9126.rectTransform, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(width - 40f, 100f));
        _0xcae6177a.Face(_0x99fb18ff, () => _0x9d28afe5.Invoke());
    }

    private TextMeshProUGUI _0x8ffe02a0;
    private TextMeshProUGUI _0x0447f475(RectTransform _0xc81046ec, string _0xc046022d, Color _0x62d563e5)
    {
        TextMeshProUGUI _0x7b8b75f7 = _0xcae6177a.Label(_0xc81046ec, _0xade90d97._0xd8a8591a(new byte[6] { 46, 35, 39, 34, 35, 52 }, 102), _0xc046022d, 82f, _0x62d563e5, this._font, TextAlignmentOptions.Center);
        _0xcae6177a.Place(_0x7b8b75f7.rectTransform, new Vector2(0.5f, 1f), new Vector2(0f, -462f), new Vector2(940f, 200f));
        return _0x7b8b75f7;
    }

    private void _0x98d1ce33(RectTransform _0x6fadbc95, Color _0xc78aabdf, System.Action _0xab9983f0)
    {
        Image _0xc9678516 = _0xcae6177a.Plate(_0x6fadbc95, _0xade90d97._0xd8a8591a(new byte[9] { 69, 83, 73, 88, 68, 75, 72, 84, 66 }, 7), this._plateSprite, _0x1c710ab2.Fade(_0xc78aabdf, 0.85f), 1.4f);
        _0xcae6177a.Place(_0xc9678516.rectTransform, new Vector2(1f, 1f), new Vector2(-54f, -54f), new Vector2(104f, 104f));
        Image _0x06fb8aef = _0xcae6177a.Plate(_0xc9678516.rectTransform, _0xade90d97._0xd8a8591a(new byte[4] { 128, 143, 138, 138 }, 198), this._plateSprite, _0x1c710ab2.Surface, 1.5f);
        _0xcae6177a.Place(_0x06fb8aef.rectTransform, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(94f, 94f));
        Image _0x4f7b2158 = _0xcae6177a.Picture(_0x06fb8aef.rectTransform, _0xade90d97._0xd8a8591a(new byte[4] { 144, 154, 150, 151 }, 217), this._iconClose, _0x1c710ab2.TextPrimary);
        _0xcae6177a.Place(_0x4f7b2158.rectTransform, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(48f, 48f));
        _0xcae6177a.Face(_0x06fb8aef, () => _0xab9983f0.Invoke());
    }

    private TextMeshProUGUI _0x9582dc43;
    public void _0xf83fee12(int _0xd233d853, int _0xf3986c0c, float _0x69ef18a7, int _0x31650f42, int _0xe4e3dccd)
    {
        _0x673f471c _0x9496be3c = _0xf905b1bd.Instance._0x399c969a(_0xcb53ffe7._0x8436a0ff.WIN);
        if (_0x9496be3c == null || _0x9496be3c.Content == null)
        {
            return;
        }

        if (this._0x8ffe02a0 == null)
        {
            RectTransform _0x113daca0 = this._0xfc6a68bc(_0x9496be3c, _0x1c710ab2.Gold);
            this._0x2c5f05b9(_0x113daca0, this._beaconSprite, _0x1c710ab2.Gold);
            this._0x8ffe02a0 = this._0x0447f475(_0x113daca0, _0xade90d97._0xd8a8591a(new byte[14] { 87, 80, 84, 86, 90, 91, 53, 71, 80, 84, 86, 93, 80, 81 }, 21), _0x1c710ab2.Gold);
            this._0x9582dc43 = this._0x53983847(_0x113daca0, _0xade90d97._0xd8a8591a(new byte[15] { 220, 202, 204, 219, 198, 192, 193, 175, 191, 191, 175, 160, 175, 191, 191 }, 143));
            this._0xcb183d6e = this._0xa7b72357(_0x113daca0, _0xade90d97._0xd8a8591a(new byte[14] { 75, 70, 74, 68, 75, 87, 35, 51, 45, 51, 51, 35, 72, 78 }, 3));
            this._0x47e4d5f3(_0x113daca0, _0xade90d97._0xd8a8591a(new byte[11] { 39, 40, 45, 41, 38, 68, 37, 35, 37, 45, 42 }, 100), _0xade90d97._0xd8a8591a(new byte[10] { 190, 165, 172, 171, 185, 205, 160, 168, 163, 184 }, 237), _0x1c710ab2.Gold);
            this._0x98d1ce33(_0x113daca0, _0x1c710ab2.Gold, () => _0xbecc5006.Instance.LoadSceneByIndex(_0xcb53ffe7._0xd8635e47.SCENE_0));
        }

        this._0x9582dc43.text = _0xade90d97._0xd8a8591a(new byte[8] { 87, 65, 71, 80, 77, 75, 74, 36 }, 4) + _0xd233d853.ToString(_0xade90d97._0xd8a8591a(new byte[2] { 9, 9 }, 57)) + _0xade90d97._0xd8a8591a(new byte[3] { 91, 84, 91 }, 123) + _0xf3986c0c.ToString(_0xade90d97._0xd8a8591a(new byte[2] { 45, 45 }, 29));
        this._0xcb183d6e.text = _0xade90d97._0xd8a8591a(new byte[7] { 16, 29, 17, 31, 16, 12, 120 }, 88) + _0x69ef18a7.ToString(_0xade90d97._0xd8a8591a(new byte[4] { 39, 57, 39, 39 }, 23)) + _0xade90d97._0xd8a8591a(new byte[3] { 53, 94, 88 }, 21) + _0xade90d97._0xd8a8591a(new byte[6] { 227, 161, 188, 165, 165, 201 }, 233) + _0x31650f42 + _0xade90d97._0xd8a8591a(new byte[3] { 60, 51, 60 }, 28) + _0xe4e3dccd;
        this._0xa3ccfc60(_0x9496be3c);
        _0xf905b1bd.Instance._0x6698f986(_0xcb53ffe7._0x8436a0ff.WIN);
    }

    [SerializeField]
    private Sprite _beaconSprite;
    [SerializeField]
    private Sprite _plateSprite;
    private void _0x490be34e()
    {
        _0xf905b1bd.Instance._0x4a3f24e3();
        if (this._0x6fd19cd1 != null)
        {
            this._0x6fd19cd1.Invoke();
        }
    }

    private void _0x2c5f05b9(RectTransform _0x35bc053f, Sprite _0xfb789797, Color _0x7abd6135)
    {
        Image _0x23db7afd = _0xcae6177a.Plate(_0x35bc053f, _0xade90d97._0xd8a8591a(new byte[8] { 9, 26, 28, 23, 0, 9, 4, 7 }, 72), this._plateSprite, _0x1c710ab2.Fade(_0x7abd6135, 0.22f), 1.4f);
        _0xcae6177a.Place(_0x23db7afd.rectTransform, new Vector2(0.5f, 1f), new Vector2(0f, -212f), new Vector2(300f, 300f));
        Image _0x4ea03cc9 = _0xcae6177a.Picture(_0x23db7afd.rectTransform, _0xade90d97._0xd8a8591a(new byte[3] { 244, 231, 225 }, 181), _0xfb789797, Color.white);
        _0xcae6177a.Place(_0x4ea03cc9.rectTransform, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(228f, 228f));
    }

    [SerializeField]
    private TMP_FontAsset _font;
    private TextMeshProUGUI _0x3bd38a72;
    private TextMeshProUGUI _0x195bf519;
    // Re-opening a pop inside its own 0.4s hide tween otherwise yields an invisible,
    // uncloseable card: kill the tween WITHOUT completing it and reset the body.
    private void _0xa3ccfc60(_0x673f471c _0xfc4d5c0a)
    {
        Transform _0x74f26e84 = _0xfc4d5c0a.Content.transform;
        DOTween.Kill(_0x74f26e84);
        _0xfc4d5c0a.Content.SetActive(true);
        _0x74f26e84.localScale = Vector3.zero;
    }

    private System.Action _0x6fd19cd1;
    private void _0x47e4d5f3(RectTransform _0x3e8a0bd5, string _0x2aa7e661, string _0x01eef817, Color _0x07e063d7)
    {
        this._0xb5d62ce5(_0x3e8a0bd5, _0xade90d97._0xd8a8591a(new byte[11] { 153, 143, 149, 132, 139, 137, 146, 150, 154, 137, 130 }, 219), _0x2aa7e661, new Vector2(0f, -900f), _0x07e063d7, true, () => _0xbecc5006.Instance._0x2d4438f7());
        this._0xb5d62ce5(_0x3e8a0bd5, _0xade90d97._0xd8a8591a(new byte[8] { 199, 209, 203, 218, 200, 192, 203, 208 }, 133), _0x01eef817, new Vector2(0f, -1050f), _0x07e063d7, false, () => _0xbecc5006.Instance.LoadSceneByIndex(_0xcb53ffe7._0xd8635e47.SCENE_0));
    }

    private TextMeshProUGUI _0x3c5991b8;
    private TextMeshProUGUI _0xa7b72357(RectTransform _0x8057d9e2, string _0x2a814203)
    {
        TextMeshProUGUI _0x4fe70a98 = _0xcae6177a.Label(_0x8057d9e2, _0xade90d97._0xd8a8591a(new byte[5] { 177, 172, 160, 166, 181 }, 244), _0x2a814203, 44f, _0x1c710ab2.TextMuted, this._font, TextAlignmentOptions.Center);
        _0xcae6177a.Place(_0x4fe70a98.rectTransform, new Vector2(0.5f, 1f), new Vector2(0f, -744f), new Vector2(940f, 128f));
        return _0x4fe70a98;
    }

    private TextMeshProUGUI _0x53983847(RectTransform _0xa8de1f28, string _0xcfb60b83)
    {
        TextMeshProUGUI _0x55237cd0 = _0xcae6177a.Label(_0xa8de1f28, _0xade90d97._0xd8a8591a(new byte[4] { 2, 14, 6, 1 }, 79), _0xcfb60b83, 62f, _0x1c710ab2.TextPrimary, this._font, TextAlignmentOptions.Center);
        _0xcae6177a.Place(_0x55237cd0.rectTransform, new Vector2(0.5f, 1f), new Vector2(0f, -636f), new Vector2(940f, 92f));
        return _0x55237cd0;
    }

    private TextMeshProUGUI _0xe51604d3;
    [SerializeField]
    private Sprite _iconClose;
    private TextMeshProUGUI _0x1032fbd9;
    private TextMeshProUGUI _0xcb183d6e;
    // Wakes the pop body before anything is built into it: Pop.Awake leaves Content
    // switched off, and a TMP label added to a dead hierarchy never gets a font.
    private RectTransform _0xfc6a68bc(_0x673f471c _0xaadd191f, Color _0x7bf9e626)
    {
        GameObject _0x95883e2c = _0xaadd191f.Content;
        _0x95883e2c.SetActive(true);
        _0xcae6177a.ClearBody(_0x95883e2c.transform);
        RectTransform _0x2c25d723 = _0xcae6177a.Node(_0x95883e2c.transform, _0xade90d97._0xd8a8591a(new byte[12] { 15, 20, 29, 26, 8, 3, 14, 25, 15, 9, 16, 8 }, 92));
        Image _0x8b07e3f6 = _0xcae6177a.Plate(_0x2c25d723, _0xade90d97._0xd8a8591a(new byte[9] { 204, 206, 221, 203, 208, 221, 198, 193, 200 }, 143), this._plateSprite, _0x1c710ab2.Fade(_0x7bf9e626, 0.95f), 1.4f);
        _0xcae6177a.Place(_0x8b07e3f6.rectTransform, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(1028f, 1208f));
        Image _0xa5e4c5d2 = _0xcae6177a.Plate(_0x8b07e3f6.rectTransform, _0xade90d97._0xd8a8591a(new byte[9] { 99, 97, 114, 100, 127, 102, 105, 108, 108 }, 32), this._plateSprite, _0x1c710ab2.SurfaceHi, 1.4f);
        _0xcae6177a.Place(_0xa5e4c5d2.rectTransform, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(1012f, 1192f));
        Image _0x49aa9c37 = _0xcae6177a.Plate(_0xa5e4c5d2.rectTransform, _0xade90d97._0xd8a8591a(new byte[9] { 193, 195, 208, 198, 221, 197, 206, 205, 213 }, 130), this._plateSprite, _0x1c710ab2.Fade(_0x7bf9e626, 0.14f), 2.8f);
        _0xcae6177a.Place(_0x49aa9c37.rectTransform, new Vector2(0.5f, 1f), new Vector2(0f, -240f), new Vector2(940f, 460f));
        return _0xa5e4c5d2.rectTransform;
    }
}

internal static class _0xade90d97
{
    internal static string _0xd8a8591a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}