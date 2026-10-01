using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x7187b858 : MonoBehaviour
{
    private void Update()
    {
        this._0xf599ba91();
    }

    private Image _0x10dde2a2;
    private void _0xf599ba91()
    {
        if (this._0x10dde2a2.canvasRenderer.GetColor() != this._0x783a3f91.canvasRenderer.GetColor())
            this._0x783a3f91.canvasRenderer.SetColor(this._0x10dde2a2.canvasRenderer.GetColor());
    }

    private TMP_Text _0x783a3f91;
}