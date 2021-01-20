using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ebshseubhfhisb.Properties
{
	// Token: 0x02000004 RID: 4
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000032 RID: 50 RVA: 0x000053B9 File Offset: 0x000035B9
		internal Resources()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000033 RID: 51 RVA: 0x000053C4 File Offset: 0x000035C4
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("ColdWarTool.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000034 RID: 52 RVA: 0x0000540C File Offset: 0x0000360C
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00005423 File Offset: 0x00003623
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

		// Token: 0x04000069 RID: 105
		private static ResourceManager resourceMan;

		// Token: 0x0400006A RID: 106
		private static CultureInfo resourceCulture;
	}
}
