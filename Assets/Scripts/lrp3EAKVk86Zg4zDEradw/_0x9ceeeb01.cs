using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// A living slice of the shaft on the menu: the container hops from ledge to ledge
// while two beams sweep across it. It is the one place on the menu where art
// moves, and it explains the game before a word of copy does. Picking a different
// route re-times the beams here, which is the visible half of the route choice.
public sealed class _0x9ceeeb01 : MonoBehaviour
{
    private Image _0x7fc5d114;
    private float _0x48f37728;
    [SerializeField]
    private Sprite _plateSprite;
    private readonly float[] _0xb35c1c2b =
    {
        -286f,
        286f,
        -286f
    };
    public void Build(RectTransform _0x596ebdd6)
    {
        if (_0x596ebdd6 == null)
        {
            return;
        }

        Image _0x00f3c637 = _0xcae6177a.Plate(_0x596ebdd6, _0x074a0854._0x7647d57b(new byte[12] { 165, 167, 176, 163, 188, 176, 162, 170, 162, 176, 185, 185 }, 245), this._plateSprite, _0x1c710ab2.Fade(_0x1c710ab2.BgDeeper, 0.72f), 1.4f);
        _0xcae6177a.Place(_0x00f3c637.rectTransform, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(900f, 760f));
        Image _0xf6c1981a = _0xcae6177a.Plate(_0x00f3c637.rectTransform, _0x074a0854._0x7647d57b(new byte[13] { 109, 111, 120, 107, 116, 120, 106, 98, 123, 111, 124, 112, 120 }, 61), this._plateSprite, _0x1c710ab2.Fade(_0x1c710ab2.Accent, 0.35f), 1.4f);
        _0xcae6177a.Place(_0xf6c1981a.rectTransform, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(906f, 766f));
        _0xf6c1981a.transform.SetAsFirstSibling();
        for (int _0x3846d5ef = -1; _0x3846d5ef <= 1; _0x3846d5ef += 2)
        {
            Image _0xc6691685 = _0xcae6177a.Solid(_0x00f3c637.rectTransform, _0x074a0854._0x7647d57b(new byte[12] { 143, 141, 154, 137, 150, 154, 136, 128, 136, 158, 147, 147 }, 223), _0x1c710ab2.Surface);
            _0xcae6177a.Place(_0xc6691685.rectTransform, new Vector2(0.5f, 0.5f), new Vector2(_0x3846d5ef * 390f, 0f), new Vector2(120f, 740f));
            Image _0x817756da = _0xcae6177a.Solid(_0xc6691685.rectTransform, _0x074a0854._0x7647d57b(new byte[17] { 61, 63, 40, 59, 36, 40, 58, 50, 58, 44, 33, 33, 50, 40, 41, 42, 40 }, 109), _0x1c710ab2.Fade(_0x1c710ab2.AccentGlow, 0.55f));
            _0xcae6177a.Place(_0x817756da.rectTransform, new Vector2(0.5f, 0.5f), new Vector2(-_0x3846d5ef * 58f, 0f), new Vector2(5f, 740f));
        }

        Image _0xbb4e8307 = _0xcae6177a.Picture(_0x00f3c637.rectTransform, _0x074a0854._0x7647d57b(new byte[14] { 169, 171, 188, 175, 176, 188, 174, 166, 187, 188, 184, 186, 182, 183 }, 249), this._beaconSprite, _0x1c710ab2.Gold);
        _0xcae6177a.Place(_0xbb4e8307.rectTransform, new Vector2(0.5f, 1f), new Vector2(40f, -96f), new Vector2(150f, 150f));
        for (int _0x154e3225 = 0; _0x154e3225 < this._0xb5757079.Length; _0x154e3225++)
        {
            Image _0xea0f9403 = _0xcae6177a.Picture(_0x00f3c637.rectTransform, _0x074a0854._0x7647d57b(new byte[14] { 65, 67, 84, 71, 88, 84, 70, 78, 93, 84, 85, 86, 84, 78 }, 17) + _0x154e3225, this._bracketSprite, _0x1c710ab2.Fade(_0x1c710ab2.Accent, 0.75f));
            _0xcae6177a.Place(_0xea0f9403.rectTransform, new Vector2(0.5f, 0.5f), new Vector2(this._0xb35c1c2b[_0x154e3225], this._0xb5757079[_0x154e3225] - 62f), new Vector2(210f, 105f));
            this._0xa110d961.Add(_0xea0f9403);
        }

        for (int _0x8131b4f6 = 0; _0x8131b4f6 < 2; _0x8131b4f6++)
        {
            Image _0x335cb913 = _0xcae6177a.Picture(_0x00f3c637.rectTransform, _0x074a0854._0x7647d57b(new byte[13] { 128, 130, 149, 134, 153, 149, 135, 143, 146, 149, 145, 157, 143 }, 208) + _0x8131b4f6, this._beamSprite, _0x1c710ab2.Danger);
            _0xcae6177a.Place(_0x335cb913.rectTransform, new Vector2(0.5f, 0.5f), new Vector2(0f, -130f + _0x8131b4f6 * 250f), new Vector2(430f, 64f));
            this._0x3280e3aa.Add(_0x335cb913.rectTransform);
        }

        this._0x7fc5d114 = _0xcae6177a.Picture(_0x00f3c637.rectTransform, _0x074a0854._0x7647d57b(new byte[13] { 35, 33, 54, 37, 58, 54, 36, 44, 48, 50, 33, 52, 60 }, 115), this._containerSprite, Color.white);
        this._0xaa2e145b = this._0x7fc5d114.rectTransform;
        _0xcae6177a.Place(this._0xaa2e145b, new Vector2(0.5f, 0.5f), new Vector2(this._0xb35c1c2b[0], this._0xb5757079[0]), new Vector2(150f, 150f));
    }

    private RectTransform _0xaa2e145b;
    public void _0x0815b5b0(Color _0x8b34f8a1, float _0x4bf0a867)
    {
        this._0x432df72c = Mathf.Max(0.3f, _0x4bf0a867);
        for (int _0xf74a7f4e = 0; _0xf74a7f4e < this._0xa110d961.Count; _0xf74a7f4e++)
        {
            if (this._0xa110d961[_0xf74a7f4e] != null)
            {
                this._0xa110d961[_0xf74a7f4e].color = _0x1c710ab2.Fade(_0x8b34f8a1, 0.75f);
            }
        }

        if (this._0x7fc5d114 != null)
        {
            this._0x7fc5d114.color = Color.white;
        }
    }

    private float _0x432df72c = 1f;
    private readonly List<RectTransform> _0x3280e3aa = new List<RectTransform>();
    private readonly List<Image> _0xa110d961 = new List<Image>();
    [SerializeField]
    private Sprite _beamSprite;
    [SerializeField]
    private Sprite _containerSprite;
    [SerializeField]
    private Sprite _beaconSprite;
    [SerializeField]
    private Sprite _bracketSprite;
    private void Update()
    {
        if (this._0xaa2e145b == null)
        {
            return;
        }

        this._0x48f37728 += Time.deltaTime;
        float _0x279ac41c = 2.4f;
        float _0x0c39a414 = Mathf.Repeat(this._0x48f37728, _0x279ac41c * this._0xb5757079.Length) / _0x279ac41c;
        int _0x2d1a3a32 = Mathf.FloorToInt(_0x0c39a414) % this._0xb5757079.Length;
        int _0xc40dba32 = (_0x2d1a3a32 + 1) % this._0xb5757079.Length;
        float _0x1fc19ad9 = Mathf.Clamp01((_0x0c39a414 - Mathf.Floor(_0x0c39a414)) * 1.9f);
        float _0x3ea7f764 = 1f - (1f - _0x1fc19ad9) * (1f - _0x1fc19ad9);
        Vector2 _0x09127441 = new Vector2(Mathf.Lerp(this._0xb35c1c2b[_0x2d1a3a32], this._0xb35c1c2b[_0xc40dba32], _0x3ea7f764), Mathf.Lerp(this._0xb5757079[_0x2d1a3a32], this._0xb5757079[_0xc40dba32], _0x3ea7f764));
        this._0xaa2e145b.anchoredPosition = _0x09127441;
        float _0xd181dcaf = 1f + 0.1f * Mathf.Sin(Mathf.Clamp01(_0x1fc19ad9) * Mathf.PI);
        this._0xaa2e145b.sizeDelta = new Vector2(150f * _0xd181dcaf, 150f * _0xd181dcaf);
        for (int _0x3a152942 = 0; _0x3a152942 < this._0x3280e3aa.Count; _0x3a152942++)
        {
            RectTransform _0x9100a5cf = this._0x3280e3aa[_0x3a152942];
            if (_0x9100a5cf == null)
            {
                continue;
            }

            float _0x858b3a57 = Mathf.Sin(this._0x48f37728 * 1.1f * this._0x432df72c + _0x3a152942 * 1.7f) * 190f;
            Vector2 _0x54e2b750 = _0x9100a5cf.anchoredPosition;
            _0x54e2b750.x = _0x858b3a57;
            _0x9100a5cf.anchoredPosition = _0x54e2b750;
        }
    }

    private readonly float[] _0xb5757079 =
    {
        -250f,
        -10f,
        230f
    };
}

internal static class _0x074a0854
{
    internal static string _0x7647d57b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}