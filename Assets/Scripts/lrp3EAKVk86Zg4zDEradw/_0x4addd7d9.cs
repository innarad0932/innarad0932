using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Builds the menu inside the template's own default panel. The template ships a
// single invisible button in that panel carrying the load-scene driver; this
// script gives it a face and points its tint at that face, so there is exactly
// one Play button and exactly one thing that loads the run.
public sealed class _0x4addd7d9 : MonoBehaviour
{
    private void _0x184b8164(RectTransform _0xe9961385, string _0xe34b0ae1, string _0xe2887212, Vector2 _0x924c12c2, System.Action _0x80514d13)
    {
        Image _0x702c2160 = _0xcae6177a.Plate(_0xe9961385, _0xe34b0ae1, this._plateSprite, _0x1c710ab2.Fade(_0x1c710ab2.Accent2, 0.9f), 1.4f);
        _0xcae6177a.Place(_0x702c2160.rectTransform, new Vector2(0.5f, 0.155f), _0x924c12c2, new Vector2(376f, 128f));
        Image _0x5c803874 = _0xcae6177a.Plate(_0x702c2160.rectTransform, _0x08d9a3fe._0xf7f56c31(new byte[4] { 173, 162, 167, 167 }, 235), this._plateSprite, _0x1c710ab2.Surface, 1.5f);
        _0xcae6177a.Place(_0x5c803874.rectTransform, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(366f, 118f));
        TextMeshProUGUI _0x206895e4 = _0xcae6177a.Label(_0x5c803874.rectTransform, _0x08d9a3fe._0xf7f56c31(new byte[5] { 110, 99, 96, 103, 110 }, 34), _0xe2887212, 44f, _0x1c710ab2.TextPrimary, this._font, TextAlignmentOptions.Center);
        _0xcae6177a.Place(_0x206895e4.rectTransform, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(340f, 96f));
        _0xcae6177a.Face(_0x5c803874, () => _0x80514d13.Invoke());
    }

    [SerializeField]
    private _0xe180ebfc _routes;
    private TextMeshProUGUI _0x31b49c20;
    private void _0xe5a7cb94(RectTransform _0x5319be10)
    {
        RectTransform _0x259ec7c2 = _0xcae6177a.Node(_0x5319be10, _0x08d9a3fe._0xf7f56c31(new byte[12] { 152, 154, 141, 158, 129, 141, 159, 151, 155, 132, 135, 156 }, 200));
        _0xcae6177a.Place(_0x259ec7c2, new Vector2(0.5f, 0.715f), Vector2.zero, new Vector2(920f, 780f));
        if (this._preview != null)
        {
            this._preview.Build(_0x259ec7c2);
        }
    }

    private void _0xd043bd99(RectTransform _0x608d437b)
    {
        Image _0x22b514d0 = _0xcae6177a.Plate(_0x608d437b, _0x08d9a3fe._0xf7f56c31(new byte[10] { 195, 196, 210, 213, 222, 209, 205, 192, 213, 196 }, 129), this._plateSprite, _0x1c710ab2.Fade(_0x1c710ab2.Gold, 0.75f), 1.4f);
        _0xcae6177a.Place(_0x22b514d0.rectTransform, new Vector2(0.5f, 0.505f), Vector2.zero, new Vector2(704f, 136f));
        Image _0xc959425f = _0xcae6177a.Plate(_0x22b514d0.rectTransform, _0x08d9a3fe._0xf7f56c31(new byte[4] { 84, 91, 94, 94 }, 18), this._plateSprite, _0x1c710ab2.Surface, 1.5f);
        _0xcae6177a.Place(_0xc959425f.rectTransform, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(696f, 128f));
        TextMeshProUGUI _0x32260030 = _0xcae6177a.Label(_0xc959425f.rectTransform, _0x08d9a3fe._0xf7f56c31(new byte[7] { 187, 185, 168, 172, 177, 183, 182 }, 248), _0x08d9a3fe._0xf7f56c31(new byte[4] { 70, 65, 87, 80 }, 4), 34f, _0x1c710ab2.TextMuted, this._font, TextAlignmentOptions.Left);
        _0xcae6177a.Place(_0x32260030.rectTransform, new Vector2(0f, 0.5f), new Vector2(120f, 0f), new Vector2(180f, 60f));
        this._0x31b49c20 = _0xcae6177a.Label(_0xc959425f.rectTransform, _0x08d9a3fe._0xf7f56c31(new byte[5] { 245, 226, 239, 246, 230 }, 163), _0xcb53ffe7._0x60707aff._0x6f92c0dd + _0x08d9a3fe._0xf7f56c31(new byte[9] { 207, 188, 170, 172, 187, 166, 160, 161, 188 }, 239), 56f, _0x1c710ab2.Gold, this._font, TextAlignmentOptions.Right);
        _0xcae6177a.Place(this._0x31b49c20.rectTransform, new Vector2(1f, 0.5f), new Vector2(-150f, 0f), new Vector2(420f, 76f));
    }

    [SerializeField]
    private _0x9ceeeb01 _preview;
    [SerializeField]
    private _0x25a19073 _tutorial;
    [SerializeField]
    private Sprite _markSprite;
    private void _0x42e4fc59(RectTransform _0x785360a4)
    {
        this._0x57fcc685 = _0xcae6177a.Label(_0x785360a4, _0x08d9a3fe._0xf7f56c31(new byte[9] { 212, 217, 209, 222, 216, 207, 210, 205, 222 }, 155), _0x08d9a3fe._0xf7f56c31(new byte[16] { 252, 235, 239, 237, 230, 142, 250, 230, 235, 142, 236, 235, 239, 237, 225, 224 }, 174), 38f, _0x1c710ab2.Fade(_0x1c710ab2.TextPrimary, 0.9f), this._font, TextAlignmentOptions.Center);
        _0xcae6177a.Place(this._0x57fcc685.rectTransform, new Vector2(0.5f, 0.415f), Vector2.zero, new Vector2(1040f, 70f));
        Image _0xbd1b39de = _0xcae6177a.Solid(_0x785360a4, _0x08d9a3fe._0xf7f56c31(new byte[14] { 213, 216, 208, 223, 217, 206, 211, 204, 223, 197, 200, 207, 214, 223 }, 154), _0x1c710ab2.Fade(_0x1c710ab2.Accent, 0.4f));
        _0xcae6177a.Place(_0xbd1b39de.rectTransform, new Vector2(0.5f, 0.385f), Vector2.zero, new Vector2(760f, 3f));
        TextMeshProUGUI _0x535cab4b = _0xcae6177a.Label(_0x785360a4, _0x08d9a3fe._0xf7f56c31(new byte[7] { 205, 207, 217, 222, 223, 216, 207 }, 138), _0x08d9a3fe._0xf7f56c31(new byte[54] { 54, 49, 50, 58, 94, 42, 49, 94, 44, 55, 45, 59, 94, 83, 94, 44, 59, 50, 59, 63, 45, 59, 94, 42, 49, 94, 61, 50, 63, 51, 46, 116, 42, 63, 46, 94, 56, 49, 44, 94, 49, 48, 59, 94, 45, 63, 56, 59, 94, 60, 49, 49, 45, 42 }, 126), 34f, _0x1c710ab2.TextMuted, this._font, TextAlignmentOptions.Center);
        _0xcae6177a.Place(_0x535cab4b.rectTransform, new Vector2(0.5f, 0.335f), Vector2.zero, new Vector2(1040f, 128f));
    }

    [SerializeField]
    private Sprite _plateSprite;
    private void _0xc9f10e5e(int _0x0dc29e9a)
    {
        if (this._preview != null)
        {
            this._preview._0x0815b5b0(_0x1c710ab2.RouteAccent(_0x0dc29e9a), _0xe8c9d026.BeamSpeedScaleOf(_0x0dc29e9a));
        }

        if (this._0x57fcc685 != null)
        {
            this._0x57fcc685.text = _0x08d9a3fe._0xf7f56c31(new byte[6] { 67, 94, 68, 69, 84, 49 }, 17) + _0xe8c9d026.NameOf(_0x0dc29e9a) + _0x08d9a3fe._0xf7f56c31(new byte[3] { 137, 134, 137 }, 169) + _0xe8c9d026.SectionsOf(_0x0dc29e9a) + _0x08d9a3fe._0xf7f56c31(new byte[23] { 244, 135, 145, 151, 128, 157, 155, 154, 135, 244, 128, 155, 244, 128, 156, 145, 244, 150, 145, 149, 151, 155, 154 }, 212);
        }

        if (this._0x31b49c20 != null)
        {
            this._0x31b49c20.text = _0xcb53ffe7._0x60707aff._0x6f92c0dd + _0x08d9a3fe._0xf7f56c31(new byte[9] { 168, 219, 205, 203, 220, 193, 199, 198, 219 }, 136);
        }
    }

    private TextMeshProUGUI _0x57fcc685;
    private void _0xac468fd2()
    {
        if (this._routes != null)
        {
            this._routes._0x18ea04b4();
        }
    }

    private void _0xa95b5f31(RectTransform _0x186dc124)
    {
        Image _0x32fba41a = _0xcae6177a.Plate(_0x186dc124, _0x08d9a3fe._0xf7f56c31(new byte[10] { 52, 36, 55, 56, 50, 41, 62, 55, 58, 57 }, 118), this._plateSprite, _0x1c710ab2.Fade(_0x1c710ab2.Accent, 0.18f), 1.4f);
        _0xcae6177a.Place(_0x32fba41a.rectTransform, new Vector2(0.5f, 0.945f), Vector2.zero, new Vector2(176f, 176f));
        Image _0xc1e6f940 = _0xcae6177a.Picture(_0x32fba41a.rectTransform, _0x08d9a3fe._0xf7f56c31(new byte[10] { 138, 154, 137, 134, 140, 151, 133, 137, 154, 131 }, 200), this._markSprite, Color.white);
        _0xcae6177a.Place(_0xc1e6f940.rectTransform, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(126f, 126f));
        Image _0x43fd4368 = _0xcae6177a.Solid(_0x186dc124, _0x08d9a3fe._0xf7f56c31(new byte[10] { 25, 9, 26, 21, 31, 4, 9, 14, 23, 30 }, 91), _0x1c710ab2.Fade(_0x1c710ab2.AccentGlow, 0.5f));
        _0xcae6177a.Place(_0x43fd4368.rectTransform, new Vector2(0.5f, 0.9f), Vector2.zero, new Vector2(320f, 4f));
    }

    [SerializeField]
    private TMP_FontAsset _font;
    private void _0x94a904a9(RectTransform _0xe5c56c3c)
    {
        this._0x184b8164(_0xe5c56c3c, _0x08d9a3fe._0xf7f56c31(new byte[10] { 182, 160, 186, 171, 166, 187, 161, 160, 177, 167 }, 244), _0x08d9a3fe._0xf7f56c31(new byte[6] { 177, 172, 182, 183, 166, 176 }, 227), new Vector2(-200f, 0f), () => this._0xac468fd2());
        this._0x184b8164(_0xe5c56c3c, _0x08d9a3fe._0xf7f56c31(new byte[9] { 170, 188, 166, 183, 160, 167, 191, 188, 167 }, 232), _0x08d9a3fe._0xf7f56c31(new byte[11] { 92, 91, 67, 52, 64, 91, 52, 68, 88, 85, 77 }, 20), new Vector2(200f, 0f), () => this._0xbd7b4cc5());
    }

    private void _0xbd7b4cc5()
    {
        if (_0x3e2c0a04.Instance != null)
        {
            _0x3e2c0a04.Instance._0x83b29986(_0xcb53ffe7._0x51899f64.TUTORIAL0);
        }
    }

    private void _0x0beaf578(RectTransform _0xada0ada2)
    {
        TextMeshProUGUI _0x6e1f4699 = _0xcae6177a.Label(_0xada0ada2, _0x08d9a3fe._0xf7f56c31(new byte[6] { 94, 87, 87, 76, 93, 74 }, 24), _0x08d9a3fe._0xf7f56c31(new byte[40] { 166, 171, 171, 199, 179, 175, 181, 162, 162, 199, 180, 175, 166, 161, 179, 180, 199, 166, 181, 162, 199, 168, 183, 162, 169, 199, 161, 181, 168, 170, 199, 179, 175, 162, 199, 180, 179, 166, 181, 179 }, 231), 30f, _0x1c710ab2.Fade(_0x1c710ab2.TextMuted, 0.9f), this._font, TextAlignmentOptions.Center);
        _0xcae6177a.Place(_0x6e1f4699.rectTransform, new Vector2(0.5f, 0.072f), Vector2.zero, new Vector2(1040f, 52f));
    }

    [SerializeField]
    private _0x6e6232e8 _splash;
    private void _0x4ee54f44(RectTransform _0xa1b3de86)
    {
        Image _0xbda28cce = _0xcae6177a.Solid(_0xa1b3de86, _0x08d9a3fe._0xf7f56c31(new byte[4] { 100, 114, 96, 123 }, 51), _0x1c710ab2.Fade(_0x1c710ab2.BgDeep, 0.42f));
        _0xcae6177a.Stretch(_0xbda28cce.rectTransform);
        for (int _0x923fa3ac = 0; _0x923fa3ac < 3; _0x923fa3ac++)
        {
            Image _0x69a0d051 = _0xcae6177a.Solid(_0xa1b3de86, _0x08d9a3fe._0xf7f56c31(new byte[4] { 98, 113, 105, 111 }, 48) + _0x923fa3ac, _0x1c710ab2.Fade(_0x1c710ab2.Accent, 0.1f));
            _0xcae6177a.Place(_0x69a0d051.rectTransform, new Vector2(0.5f, 0.5f), new Vector2(-460f + _0x923fa3ac * 300f, 420f - _0x923fa3ac * 120f), new Vector2(140f, 3400f));
            _0x69a0d051.rectTransform.localRotation = Quaternion.Euler(0f, 0f, 24f);
        }

        Image _0xe7c1690c = _0xcae6177a.Solid(_0xa1b3de86, _0x08d9a3fe._0xf7f56c31(new byte[12] { 181, 170, 164, 173, 166, 183, 183, 166, 188, 183, 172, 179 }, 227), _0x1c710ab2.Fade(_0x1c710ab2.BgDeeper, 0.82f));
        _0xcae6177a.Place(_0xe7c1690c.rectTransform, new Vector2(0.5f, 1f), new Vector2(0f, -170f), new Vector2(1242f, 340f));
        Image _0xbdda20f1 = _0xcae6177a.Solid(_0xa1b3de86, _0x08d9a3fe._0xf7f56c31(new byte[15] { 4, 27, 21, 28, 23, 6, 6, 23, 13, 16, 29, 6, 6, 29, 31 }, 82), _0x1c710ab2.Fade(_0x1c710ab2.BgDeeper, 0.9f));
        _0xcae6177a.Place(_0xbdda20f1.rectTransform, new Vector2(0.5f, 0f), new Vector2(0f, 300f), new Vector2(1242f, 600f));
    }

    // The template button is invisible by design: every layer it owns is switched
    // off and none of them is a raycast target. A face added as its child both
    // draws it and makes it pressable, because the click bubbles up to the Button
    // that already carries the driver - no second driver, no double scene load.
    private void _0x2b9d224b(Transform _0xc750d6b9)
    {
        _0xd00f2910 _0xf90d704d = _0xc750d6b9.GetComponentInChildren<_0xd00f2910>(true);
        if (_0xf90d704d == null)
        {
            return;
        }

        RectTransform _0xfdc6d8a4 = _0xcae6177a.Node(_0xf90d704d.transform, _0x08d9a3fe._0xf7f56c31(new byte[9] { 36, 56, 53, 45, 43, 50, 53, 55, 49 }, 116));
        // Slightly OVER-sized: the template button keeps an invisible white fade
        // layer 2px larger than its own rect, and the face has to cover it.
        Image _0xce1d6302 = _0xcae6177a.Plate(_0xfdc6d8a4, _0x08d9a3fe._0xf7f56c31(new byte[4] { 250, 225, 230, 239 }, 168), this._plateSprite, _0x1c710ab2.AccentGlow, 1.4f);
        _0xcae6177a.Stretch(_0xce1d6302.rectTransform);
        _0xce1d6302.rectTransform.sizeDelta = new Vector2(10f, 10f);
        _0xce1d6302.raycastTarget = true;
        Image _0x39ee24da = _0xcae6177a.Plate(_0xce1d6302.rectTransform, _0x08d9a3fe._0xf7f56c31(new byte[4] { 110, 97, 100, 100 }, 40), this._plateSprite, _0x1c710ab2.Accent, 1.5f);
        _0xcae6177a.Place(_0x39ee24da.rectTransform, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(748f, 156f));
        _0x39ee24da.raycastTarget = true;
        Image _0xb2a404cc = _0xcae6177a.Plate(_0x39ee24da.rectTransform, _0x08d9a3fe._0xf7f56c31(new byte[5] { 124, 103, 106, 106, 97 }, 47), this._plateSprite, _0x1c710ab2.Fade(_0x1c710ab2.AccentGlow, 0.3f), 2.8f);
        _0xcae6177a.Place(_0xb2a404cc.rectTransform, new Vector2(0.5f, 1f), new Vector2(0f, -40f), new Vector2(720f, 66f));
        TextMeshProUGUI _0x158e087d = _0xcae6177a.Label(_0x39ee24da.rectTransform, _0x08d9a3fe._0xf7f56c31(new byte[5] { 80, 93, 94, 89, 80 }, 28), _0x08d9a3fe._0xf7f56c31(new byte[4] { 158, 130, 143, 151 }, 206), 64f, _0x1c710ab2.TextPrimary, this._font, TextAlignmentOptions.Center);
        _0xcae6177a.Place(_0x158e087d.rectTransform, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(700f, 120f));
        Button _0x7bead7c6 = _0xf90d704d.Button;
        if (_0x7bead7c6 == null)
        {
            _0x7bead7c6 = _0xf90d704d.GetComponent<Button>();
        }

        if (_0x7bead7c6 != null)
        {
            _0x7bead7c6.targetGraphic = _0x39ee24da;
            ColorBlock _0x2758c055 = _0x7bead7c6.colors;
            _0x2758c055.normalColor = Color.white;
            _0x2758c055.highlightedColor = Color.white;
            _0x2758c055.pressedColor = new Color(0.66f, 0.74f, 0.95f, 1f);
            _0x2758c055.selectedColor = Color.white;
            _0x2758c055.fadeDuration = 0.08f;
            _0x7bead7c6.colors = _0x2758c055;
        }

        _0xfdc6d8a4.localScale = Vector3.one * 0.9f;
        _0xfdc6d8a4.DOScale(1f, 0.4f).SetEase(Ease.OutBack).SetDelay(0.15f);
    }

    private void Start()
    {
        if (this._splash != null)
        {
            this._splash._0xd3f77e7a();
        }

        if (this._tutorial != null)
        {
            this._tutorial._0x9e5dfd12();
        }

        if (_0x3e2c0a04.Instance == null)
        {
            return;
        }

        List<_0x64710ced> _0x6977f282 = _0x3e2c0a04.Instance.Panels;
        if (_0x6977f282 == null || _0x6977f282.Count <= _0xcb53ffe7._0x51899f64.DEFAULT)
        {
            return;
        }

        _0x64710ced _0xde46100b = _0x6977f282[_0xcb53ffe7._0x51899f64.DEFAULT];
        if (_0xde46100b == null || _0xde46100b.Content == null)
        {
            return;
        }

        Transform _0xb2e9fb8f = _0xde46100b.Content.transform;
        // The template's Play button is already a child of this body. The menu is
        // laid out UNDER it and the route sheet OVER it, so the button keeps both
        // its place in the draw order and its tap.
        RectTransform _0x56d541cf = _0xcae6177a.Node(_0xb2e9fb8f, _0x08d9a3fe._0xf7f56c31(new byte[15] { 192, 219, 210, 213, 199, 204, 222, 214, 221, 198, 204, 209, 210, 192, 214 }, 147));
        _0x56d541cf.SetAsFirstSibling();
        this._0x4ee54f44(_0x56d541cf);
        this._0xa95b5f31(_0x56d541cf);
        this._0xe5a7cb94(_0x56d541cf);
        this._0xd043bd99(_0x56d541cf);
        this._0x42e4fc59(_0x56d541cf);
        this._0x94a904a9(_0x56d541cf);
        this._0x0beaf578(_0x56d541cf);
        this._0x2b9d224b(_0xb2e9fb8f);
        RectTransform _0x681e9724 = _0xcae6177a.Node(_0xb2e9fb8f, _0x08d9a3fe._0xf7f56c31(new byte[14] { 206, 213, 220, 219, 201, 194, 208, 216, 211, 200, 194, 201, 210, 205 }, 157));
        _0x681e9724.SetAsLastSibling();
        if (this._routes != null)
        {
            this._routes.Build(_0x681e9724, _0xfabff29d => this._0xc9f10e5e(_0xfabff29d));
        }

        this._0xc9f10e5e(_0xe8c9d026._0x815ca20b);
    }
}

internal static class _0x08d9a3fe
{
    internal static string _0xf7f56c31(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}