using UnityEngine;
using UnityEngine.UI;

public class _0xff63c346 : MonoBehaviour
{
    private void Awake()
    {
        if (this._0xa7a5e017 == null)
            if (!this.TryGetComponent(out this._0xa7a5e017))
                this._0xa7a5e017 = this.GetComponentInChildren<Button>();
    }

    private int _0x9253d97f;
    private void Start()
    {
        if (this._0x55737746)
            this._0xa7a5e017.onClick.AddListener(() => _0x3e2c0a04.Instance._0xb81dd567());
        else
            this._0xa7a5e017.onClick.AddListener(() => _0x3e2c0a04.Instance._0x83b29986(this._0x9253d97f));
    }

    private Button _0xa7a5e017;
    private bool _0x55737746;
}