﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GladBehaviour.Editor
{
	public interface ISerializedObjectReferenceProvider
	{
		object SerializedObject { get; }
	}
}