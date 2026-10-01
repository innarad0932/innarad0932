using TMPro;
using UnityEngine;
using static _0xcb53ffe7;

public class _0x765db0bd : MonoBehaviour
{
    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0x7ff18db3;
            if (this.gameObject.TryGetComponent(out _0x7ff18db3))
                this.MoneyCountText = _0x7ff18db3;
        }

        this._0x83e43a15();
    }

    public TMP_Text MoneyCountText;
    public void _0x83e43a15()
    {
        this.MoneyCountText.text = _0x60707aff._0x6f92c0dd.ToString();
    }
}