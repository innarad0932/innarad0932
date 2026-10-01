using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0xf6d887a0 : MonoBehaviour
{
    private TMP_Text _0x1b90f20d;
    private List<string> _0x9bf60be9 = new();
    private float _0x19473d50 = 4;
    private void Update()
    {
        int _0x8fd600c1 = 1;
        if (this._0x9bf60be9.Count > 0)
        {
            string _0xdb90d7ee = this._0x1b90f20d.text;
            foreach (string _0x0e1ca34e in this._0x9bf60be9)
                while (_0xdb90d7ee.Contains(_0x0e1ca34e))
                    _0xdb90d7ee = _0xdb90d7ee.Replace(_0x0e1ca34e, "");
            _0x8fd600c1 = _0xdb90d7ee.Length;
        }
        else
        {
            _0x8fd600c1 = this._0x1b90f20d.text.Length;
        }

        float _0x25e75139 = Mathf.Clamp(this._0x5e7e02f0 + this._0x11bbaee3 * _0x8fd600c1, this._0x4771973e, this._0x19473d50);
        if (!Mathf.Approximately(this._0x6e13ba24.aspectRatio, _0x25e75139))
            this._0x6e13ba24.aspectRatio = _0x25e75139;
    }

    private float _0x11bbaee3 = 0.6f;
    private AspectRatioFitter _0x6e13ba24;
    private float _0x5e7e02f0;
    private float _0x4771973e = 1.5f;
}