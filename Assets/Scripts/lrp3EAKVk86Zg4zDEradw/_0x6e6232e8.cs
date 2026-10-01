using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Dresses the loading screen both scenes share. The brand here is an abstract
// mark and a colour, never a word: the only text on the splash is the functional
// "LOADING" line under the bar.
//
// The template's loading bar ships white-on-white at one part in 255, which is
// invisible on a phone, so the fill takes the accent and the channel behind it
// takes a dark palette colour at full alpha. The bar is never resized: its track
// insets itself against the prefab size, and shrinking the root collapses the
// whole thing to nothing.
public sealed class _0x6e6232e8 : MonoBehaviour
{
    [SerializeField]
    private Sprite _plateSprite;
    private bool _0x12badbf6;
    // The loading bar lives inside the splash body as its own prefab instance, and
    // the mark above was just added on top of it, so it is pushed back to the front
    // of the draw order once the dressing is done.
    private void _0xad1397a7(Transform _0xbc6dff11)
    {
        Slider _0xc0d5f22b = _0xbc6dff11.GetComponentInChildren<Slider>(true);
        if (_0xc0d5f22b == null)
        {
            return;
        }

        RectTransform _0x2bdce851 = _0xc0d5f22b.fillRect;
        if (_0x2bdce851 != null)
        {
            Image _0x10d897d2 = _0x2bdce851.GetComponent<Image>();
            if (_0x10d897d2 != null)
            {
                _0x10d897d2.color = _0x1c710ab2.Accent;
            }

            if (_0x2bdce851.parent != null)
            {
                Image _0x618b9c31 = _0x2bdce851.parent.GetComponent<Image>();
                if (_0x618b9c31 != null)
                {
                    _0x618b9c31.color = _0x1c710ab2.TrackDark;
                }
            }
        }

        Transform _0x03229921 = _0xc0d5f22b.transform;
        while (_0x03229921.parent != null && _0x03229921.parent != _0xbc6dff11)
        {
            _0x03229921 = _0x03229921.parent;
        }

        _0x03229921.SetAsLastSibling();
    }

    [SerializeField]
    private TMP_FontAsset _font;
    [SerializeField]
    private Sprite _markSprite;
    public void _0xd3f77e7a()
    {
        if (this._0x12badbf6 || _0x3e2c0a04.Instance == null)
        {
            return;
        }

        List<_0x64710ced> _0xe0716ad7 = _0x3e2c0a04.Instance.Panels;
        if (_0xe0716ad7 == null || _0xe0716ad7.Count <= _0xcb53ffe7._0x51899f64.SPLASH)
        {
            return;
        }

        _0x64710ced _0x2118f47e = _0xe0716ad7[_0xcb53ffe7._0x51899f64.SPLASH];
        if (_0x2118f47e == null || _0x2118f47e.Content == null)
        {
            return;
        }

        this._0x12badbf6 = true;
        Transform _0x23a0299b = _0x2118f47e.Content.transform;
        RectTransform _0xc5620343 = _0xcae6177a.Node(_0x23a0299b, _0xa1c4cac1._0x5e9b3f50(new byte[12] { 97, 122, 115, 116, 102, 109, 97, 98, 126, 115, 97, 122 }, 50));
        _0xc5620343.SetAsFirstSibling();
        Image _0x84442536 = _0xcae6177a.Solid(_0xc5620343, _0xa1c4cac1._0x5e9b3f50(new byte[4] { 102, 117, 121, 124 }, 48), _0x1c710ab2.Fade(_0x1c710ab2.BgDeeper, 0.55f));
        _0xcae6177a.Stretch(_0x84442536.rectTransform);
        Image _0x88abad34 = _0xcae6177a.Plate(_0xc5620343, _0xa1c4cac1._0x5e9b3f50(new byte[9] { 98, 110, 125, 100, 112, 103, 110, 99, 96 }, 47), this._plateSprite, _0x1c710ab2.Fade(_0x1c710ab2.Accent, 0.16f), 1.4f);
        _0xcae6177a.Place(_0x88abad34.rectTransform, new Vector2(0.5f, 0.62f), Vector2.zero, new Vector2(700f, 700f));
        Image _0x5bddc11d = _0xcae6177a.Plate(_0x88abad34.rectTransform, _0xa1c4cac1._0x5e9b3f50(new byte[9] { 130, 142, 157, 132, 144, 157, 134, 129, 136 }, 207), this._plateSprite, _0x1c710ab2.Fade(_0x1c710ab2.Accent2, 0.3f), 1.4f);
        _0xcae6177a.Place(_0x5bddc11d.rectTransform, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(520f, 520f));
        Image _0x06fae608 = _0xcae6177a.Picture(_0x88abad34.rectTransform, _0xa1c4cac1._0x5e9b3f50(new byte[4] { 82, 94, 77, 84 }, 31), this._markSprite, Color.white);
        _0xcae6177a.Place(_0x06fae608.rectTransform, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(420f, 420f));
        TextMeshProUGUI _0x77a49e47 = _0xcae6177a.Label(_0xc5620343, _0xa1c4cac1._0x5e9b3f50(new byte[15] { 254, 253, 243, 246, 251, 252, 245, 237, 241, 243, 226, 230, 251, 253, 252 }, 178), _0xa1c4cac1._0x5e9b3f50(new byte[7] { 170, 169, 167, 162, 175, 168, 161 }, 230), 36f, _0x1c710ab2.Fade(_0x1c710ab2.TextPrimary, 0.75f), this._font, TextAlignmentOptions.Center);
        _0xcae6177a.Place(_0x77a49e47.rectTransform, new Vector2(0.5f, 0.17f), Vector2.zero, new Vector2(620f, 70f));
        this._0xad1397a7(_0x23a0299b);
    }
}

internal static class _0xa1c4cac1
{
    internal static string _0x5e9b3f50(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}