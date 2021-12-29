using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace DarlingLoader.Properties
{
	// Token: 0x02000003 RID: 3
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002574 File Offset: 0x00000774
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000258C File Offset: 0x0000078C
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002063 File Offset: 0x00000263
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string username
		{
			get
			{
				return (string)this["username"];
			}
			set
			{
				this["username"] = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000025B0 File Offset: 0x000007B0
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002073 File Offset: 0x00000273
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string password
		{
			get
			{
				return (string)this["password"];
			}
			set
			{
				this["password"] = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000025D4 File Offset: 0x000007D4
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00002083 File Offset: 0x00000283
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool remember
		{
			get
			{
				return (bool)this["remember"];
			}
			set
			{
				this["remember"] = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000025F8 File Offset: 0x000007F8
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002098 File Offset: 0x00000298
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public int selectedCheat
		{
			get
			{
				return (int)this["selectedCheat"];
			}
			set
			{
				this["selectedCheat"] = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000E RID: 14 RVA: 0x0000261C File Offset: 0x0000081C
		// (set) Token: 0x0600000F RID: 15 RVA: 0x000020AD File Offset: 0x000002AD
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool rememberCheat
		{
			get
			{
				return (bool)this["rememberCheat"];
			}
			set
			{
				this["rememberCheat"] = value;
			}
		}

		// Token: 0x04000003 RID: 3
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
