using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Rewrites every tutorial page the template ships so none of them can reach a
// screen with the stock filler copy still on it. The pages are addressed by their
// SETTINGS index, never by name, and the two labels on a page are told apart by
// type size rather than by sibling order, which survives obfuscation.
public sealed class _0x25a19073 : MonoBehaviour
{
    private void _0x7e1461f4(int _0xd0208acd, int _0xb960d7ed)
    {
        if (_0x3e2c0a04.Instance == null)
        {
            return;
        }

        List<_0x64710ced> _0x7796a355 = _0x3e2c0a04.Instance.Panels;
        if (_0x7796a355 == null || _0xd0208acd < 0 || _0xd0208acd >= _0x7796a355.Count)
        {
            return;
        }

        _0x64710ced _0x828661eb = _0x7796a355[_0xd0208acd];
        if (_0x828661eb == null || _0x828661eb.Content == null)
        {
            return;
        }

        TMP_Text[] _0x00c37158 = _0x828661eb.Content.GetComponentsInChildren<TMP_Text>(true);
        TMP_Text _0xa0ef1bda = null;
        TMP_Text _0x9e691245 = null;
        for (int _0x471fc023 = 0; _0x471fc023 < _0x00c37158.Length; _0x471fc023++)
        {
            TMP_Text _0x65a84400 = _0x00c37158[_0x471fc023];
            if (_0x65a84400 == null)
            {
                continue;
            }

            // Anything inside a button is that button's caption, not page copy.
            if (_0x65a84400.GetComponentInParent<Button>() != null)
            {
                continue;
            }

            if (_0xa0ef1bda == null || _0x65a84400.fontSize > _0xa0ef1bda.fontSize)
            {
                _0x9e691245 = _0xa0ef1bda;
                _0xa0ef1bda = _0x65a84400;
            }
            else if (_0x9e691245 == null || _0x65a84400.fontSize > _0x9e691245.fontSize)
            {
                _0x9e691245 = _0x65a84400;
            }
        }

        if (_0xa0ef1bda != null)
        {
            _0xa0ef1bda.text = _0x271fe288[_0xb960d7ed];
            _0xa0ef1bda.color = _0x1c710ab2.TextPrimary;
            _0xa0ef1bda.enableWordWrapping = false;
            _0xa0ef1bda.enableAutoSizing = true;
            _0xa0ef1bda.fontSizeMax = Mathf.Max(_0xa0ef1bda.fontSize, 64f);
            _0xa0ef1bda.fontSizeMin = _0xcae6177a.FontFloor;
        }

        if (_0x9e691245 != null)
        {
            _0x9e691245.text = _0x5e43c4c6[_0xb960d7ed];
            _0x9e691245.color = _0x1c710ab2.TextMuted;
            _0x9e691245.enableWordWrapping = false;
            _0x9e691245.enableAutoSizing = true;
            _0x9e691245.fontSizeMax = Mathf.Max(_0x9e691245.fontSize, 40f);
            _0x9e691245.fontSizeMin = _0xcae6177a.FontFloor;
        }
    }

    private static readonly string[] _0x5e43c4c6 =
    {
        _0x04959686._0x273e8d9a(new byte[46] { 153, 151, 151, 130, 242, 139, 157, 135, 128, 242, 148, 155, 156, 149, 151, 128, 242, 150, 157, 133, 156, 216, 147, 156, 150, 242, 134, 154, 151, 242, 145, 157, 156, 134, 147, 155, 156, 151, 128, 242, 145, 158, 155, 159, 144, 129 }, 210),
        _0x04959686._0x273e8d9a(new byte[72] { 190, 187, 180, 166, 210, 171, 189, 167, 160, 210, 180, 187, 188, 181, 183, 160, 210, 176, 183, 161, 187, 182, 183, 210, 179, 210, 190, 183, 182, 181, 183, 248, 166, 189, 210, 177, 190, 179, 191, 162, 210, 189, 188, 210, 223, 210, 191, 187, 161, 161, 210, 187, 166, 210, 179, 188, 182, 210, 171, 189, 167, 210, 161, 190, 187, 182, 183, 210, 176, 179, 177, 185 }, 242),
        _0x04959686._0x273e8d9a(new byte[60] { 208, 195, 208, 199, 204, 181, 215, 208, 212, 216, 181, 221, 220, 193, 181, 214, 218, 198, 193, 198, 181, 218, 219, 208, 181, 221, 192, 217, 217, 181, 198, 208, 210, 216, 208, 219, 193, 159, 193, 221, 199, 208, 208, 181, 221, 220, 193, 198, 181, 208, 219, 209, 181, 193, 221, 208, 181, 199, 192, 219 }, 149),
        _0x04959686._0x273e8d9a(new byte[69] { 66, 35, 80, 75, 76, 81, 87, 35, 87, 66, 83, 35, 65, 86, 81, 77, 80, 35, 76, 77, 70, 35, 80, 66, 69, 70, 35, 65, 76, 76, 80, 87, 9, 70, 91, 66, 64, 87, 79, 90, 35, 76, 77, 70, 35, 80, 70, 64, 87, 74, 76, 77, 47, 35, 77, 76, 35, 65, 70, 66, 78, 35, 64, 76, 77, 87, 66, 64, 87 }, 3),
        _0x04959686._0x273e8d9a(new byte[63] { 6, 26, 23, 114, 22, 23, 17, 19, 11, 114, 20, 27, 23, 30, 22, 114, 0, 27, 1, 23, 1, 114, 20, 0, 29, 31, 114, 16, 23, 30, 29, 5, 88, 23, 4, 23, 0, 11, 114, 17, 30, 19, 31, 2, 114, 16, 7, 11, 1, 114, 11, 29, 7, 114, 26, 23, 19, 22, 114, 0, 29, 29, 31 }, 82),
        _0x04959686._0x273e8d9a(new byte[56] { 220, 192, 205, 168, 192, 221, 196, 196, 168, 218, 199, 223, 168, 201, 220, 168, 220, 192, 205, 168, 220, 199, 216, 130, 219, 192, 199, 223, 219, 168, 223, 192, 201, 220, 168, 193, 219, 168, 196, 205, 206, 220, 168, 199, 206, 168, 209, 199, 221, 218, 168, 219, 192, 205, 196, 196 }, 136),
        _0x04959686._0x273e8d9a(new byte[60] { 81, 94, 83, 95, 66, 50, 93, 92, 50, 70, 90, 87, 50, 94, 83, 65, 70, 50, 94, 87, 86, 85, 87, 24, 71, 92, 86, 87, 64, 50, 70, 90, 87, 50, 80, 87, 83, 81, 93, 92, 50, 70, 93, 50, 84, 91, 92, 91, 65, 90, 50, 70, 90, 87, 50, 65, 90, 83, 84, 70 }, 18),
    };
    private static readonly string[] _0x271fe288 =
    {
        _0x04959686._0x273e8d9a(new byte[12] { 30, 25, 26, 18, 118, 2, 25, 118, 4, 31, 5, 19 }, 86),
        _0x04959686._0x273e8d9a(new byte[16] { 55, 32, 41, 32, 36, 54, 32, 69, 49, 42, 69, 38, 41, 36, 40, 53 }, 101),
        _0x04959686._0x273e8d9a(new byte[14] { 210, 214, 209, 219, 191, 203, 215, 218, 191, 221, 218, 222, 210, 204 }, 159),
        _0x04959686._0x273e8d9a(new byte[15] { 148, 129, 144, 224, 134, 143, 146, 224, 129, 224, 130, 143, 143, 147, 148 }, 192),
        _0x04959686._0x273e8d9a(new byte[17] { 144, 151, 147, 134, 242, 134, 154, 151, 242, 145, 157, 158, 158, 147, 130, 129, 151 }, 210),
        _0x04959686._0x273e8d9a(new byte[13] { 192, 215, 211, 214, 178, 198, 218, 215, 178, 218, 199, 222, 222 }, 146),
        _0x04959686._0x273e8d9a(new byte[16] { 108, 123, 127, 125, 118, 30, 106, 118, 123, 30, 124, 123, 127, 125, 113, 112 }, 62),
    };
    public void _0x9e5dfd12()
    {
        this._0x7e1461f4(_0xcb53ffe7._0x51899f64.TUTORIAL0, 0);
        this._0x7e1461f4(_0xcb53ffe7._0x51899f64.TUTORIAL1, 1);
        this._0x7e1461f4(_0xcb53ffe7._0x51899f64.TUTORIAL2, 2);
        this._0x7e1461f4(_0xcb53ffe7._0x51899f64.TUTORIAL3, 3);
        this._0x7e1461f4(_0xcb53ffe7._0x51899f64.TUTORIAL4, 4);
        this._0x7e1461f4(_0xcb53ffe7._0x51899f64.TUTORIAL5, 5);
        this._0x7e1461f4(_0xcb53ffe7._0x51899f64.TUTORIAL6, 6);
    }
}

internal static class _0x04959686
{
    internal static string _0x273e8d9a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}