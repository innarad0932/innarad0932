using System.Collections.Generic;
using UnityEngine;

// The generated plan of one run: where every clamp ledge sits and how every
// energy beam sweeps. Pure data, produced by ShaftLayoutGenerator and consumed
// by ShaftRunDirector, so the run can be replayed and reasoned about.
public sealed class _0xba2ddbf5
{
    public List<_0xc882083b> Ledges = new List<_0xc882083b>();
    // Horizontal position over time is Centre + Span * sin(Rate * t + Phase):
    // bounded by construction, so a beam can never leave the shaft, and the free
    // corridor beside it is always ShaftInnerWidth - Width wide.
    public sealed class _0xdb7d2ef1
    {
        public int Band;
        public float Y;
        public float Width;
        public float Centre;
        public float Span;
        public float Rate;
        public float Phase;
        public float _0x8920a821(float _0x4042224e)
        {
            return this.Centre + this.Span * Mathf.Sin(this.Rate * _0x4042224e + this.Phase);
        }
    }

    public float BeaconX;
    public int SectionCount;
    public int Seed;
    public bool UsedFallback;
    public int RelaxedBands;
    public List<_0xdb7d2ef1> Beams = new List<_0xdb7d2ef1>();
    public sealed class _0xc882083b
    {
        public int Index;
        public int Side;
        public float Jitter;
        public float X;
        public float Y;
    }

    public float _0x9af3b595
    {
        get
        {
            if (this.Ledges.Count == 0)
            {
                return 0f;
            }

            return this.Ledges[this.Ledges.Count - 1].Y;
        }
    }
}