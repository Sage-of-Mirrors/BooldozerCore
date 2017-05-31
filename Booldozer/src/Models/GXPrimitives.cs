﻿using System;

namespace Booldozer.Models
{
	public enum GXPrimitiveType
	{
		Points = 0xB8,
		Lines = 0xA8,
		LineStrip = 0xB0,
		Triangles = 0x90,
		TriangleStrip = 0x98,
		TriangleFan = 0xA0,
		Quads = 0x80,
	}
}
