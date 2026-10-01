using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0xe6563946 : MonoBehaviour
{
    private Vector3 _0xb6640db0 { get; set; }

    private static _0xe6563946 _0xc7b5e532;
    private Color _0x65326fee = Color.white;
    private Vector3 _0x011c345d { get; set; }

    public enum _0xfbc5ab32
    {
        Landscape,
        Portrait
    }

    private Vector3 _0x04b222a5 { get; set; }

    private void Awake()
    {
        this._0xc41a593d = this.GetComponent<Camera>();
        _0xc7b5e532 = this;
        this._0x6d7cf444();
    }

    private _0xfbc5ab32 _0x966472cf = _0xfbc5ab32.Portrait;
    private Vector3 _0x0de69d03 { get; set; }
    private Vector3 _0x0cd6c286 { get; set; }
    private Vector3 _0x36f544d6 { get; set; }
    private Vector3 _0x4a98e7f1 { get; set; }
    private Vector3 _0x43fe8c36 { get; set; }

    private void _0x6d7cf444()
    {
        float _0xbd40b6a9, _0x4a41a756, _0x8db4a519, _0x9b390900;
        if (this._0x966472cf == _0xfbc5ab32.Landscape)
            this._0xc41a593d.orthographicSize = 1f / this._0xc41a593d.aspect * this._0xce50d8ec / 2f;
        else
            this._0xc41a593d.orthographicSize = this._0xce50d8ec / 2f;
        this._0x7896971e = 2f * this._0xc41a593d.orthographicSize;
        this._0x260d323a = this._0x7896971e * this._0xc41a593d.aspect;
        float _0x2e668668 = this._0xc41a593d.transform.position.x;
        float _0xfceaab49 = this._0xc41a593d.transform.position.y;
        _0xbd40b6a9 = _0x2e668668 - this._0x260d323a / 2;
        _0x4a41a756 = _0x2e668668 + this._0x260d323a / 2;
        _0x8db4a519 = _0xfceaab49 + this._0x7896971e / 2;
        _0x9b390900 = _0xfceaab49 - this._0x7896971e / 2;
        this._0xb6640db0 = new Vector3(_0xbd40b6a9, _0x9b390900, 0);
        this._0xd4f640dc = new Vector3(_0x2e668668, _0x9b390900, 0);
        this._0x0de69d03 = new Vector3(_0x4a41a756, _0x9b390900, 0);
        this._0x04b222a5 = new Vector3(_0xbd40b6a9, _0xfceaab49, 0);
        this._0x011c345d = new Vector3(_0x2e668668, _0xfceaab49, 0);
        this._0x4a98e7f1 = new Vector3(_0x4a41a756, _0xfceaab49, 0);
        this._0x36f544d6 = new Vector3(_0xbd40b6a9, _0x8db4a519, 0);
        this._0x0cd6c286 = new Vector3(_0x2e668668, _0x8db4a519, 0);
        this._0x43fe8c36 = new Vector3(_0x4a41a756, _0x8db4a519, 0);
    }

    //public bool executeInUpdate;
    private float _0x260d323a { get; set; }

    private new Camera _0xc41a593d;
    private float _0xce50d8ec = 1;
    private void OnDrawGizmos()
    {
        Gizmos.color = this._0x65326fee;
        Matrix4x4 _0x5270edc5 = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0xc41a593d.orthographic)
        {
            float _0xbc87b3c8 = this._0xc41a593d.farClipPlane - this._0xc41a593d.nearClipPlane;
            float _0x4fb8b525 = (this._0xc41a593d.farClipPlane + this._0xc41a593d.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0x4fb8b525), new Vector3(this._0xc41a593d.orthographicSize * 2 * this._0xc41a593d.aspect, this._0xc41a593d.orthographicSize * 2, _0xbc87b3c8));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0xc41a593d.fieldOfView, this._0xc41a593d.farClipPlane, this._0xc41a593d.nearClipPlane, this._0xc41a593d.aspect);
        }

        Gizmos.matrix = _0x5270edc5;
    }

    private float _0x7896971e { get; set; }
    private Vector3 _0xd4f640dc { get; set; }
}