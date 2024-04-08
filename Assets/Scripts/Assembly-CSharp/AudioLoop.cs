using System;
using UnityEngine;
using UnityEngine.Audio;
using Zorro.Core;

// Token: 0x02000013 RID: 19
public class AudioLoop : MonoBehaviour
{
	// Token: 0x04000040 RID: 64
	public AudioClip clip;

	// Token: 0x04000041 RID: 65
	public AudioMixerGroup mixerGroup;

	// Token: 0x04000042 RID: 66
	public float volume = 1f;

	// Token: 0x04000043 RID: 67
	public float pitch = 1f;

	// Token: 0x04000044 RID: 68
	public float minDistance = 1f;

	// Token: 0x04000045 RID: 69
	public float maxDistance = 100f;

	// Token: 0x04000046 RID: 70
	public bool spatialized = true;

	// Token: 0x04000047 RID: 71
	public bool occulusion = true;

	// Token: 0x04000048 RID: 72
	public bool reflections = true;

	// Token: 0x04000049 RID: 73
	public bool transmission;

	// Token: 0x0400004A RID: 74
	public bool overrideBlend;

	// Token: 0x0400004B RID: 75
	public float blend = 1f;

	// Token: 0x0400004C RID: 76
	private Optionable<float> overrideStartTime = Optionable<float>.None;

	// Token: 0x0400004D RID: 77
	private int checkID;
}
