using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ShutdownTimer.Properties
{
	// Token: 0x02000004 RID: 4
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00002BB4 File Offset: 0x00000DB4
		internal Resources()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002BC0 File Offset: 0x00000DC0
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resources.resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("ShutdownTimer.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002C0C File Offset: 0x00000E0C
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002C23 File Offset: 0x00000E23
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002C2C File Offset: 0x00000E2C
		internal static Bitmap Computer_Hardware_Shutdown_icon
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Computer-Hardware-Shutdown-icon", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x04000015 RID: 21
		private static ResourceManager resourceMan;

		// Token: 0x04000016 RID: 22
		private static CultureInfo resourceCulture;
	}
}
