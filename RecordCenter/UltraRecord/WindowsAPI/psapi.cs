﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace bfbd.UltraRecord
{
	class Psapi
	{
		[DllImport("Psapi.dll", EntryPoint="GetProcessImageFileName", SetLastError = true)]

	}
}