using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;

namespace KeyAuth
{
	// Token: 0x0200000C RID: 12
	public class api
	{
		// Token: 0x06000063 RID: 99 RVA: 0x00007BA0 File Offset: 0x00005DA0
		public api(string name, string ownerid, string secret, string version)
		{
			bool flag = string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(ownerid) || string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version);
			if (flag)
			{
				api.error("Application not setup correctly. Please watch video link found in Program.cs");
				Environment.Exit(0);
			}
			this.name = name;
			this.ownerid = ownerid;
			this.secret = secret;
			this.version = version;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00007C28 File Offset: 0x00005E28
		public void init()
		{
			this.enckey = encryption.sha256(encryption.iv_key());
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("init"));
			nameValueCollection["ver"] = encryption.encrypt(this.version, this.secret, text);
			nameValueCollection["hash"] = api.checksum(Process.GetCurrentProcess().MainModule.FileName);
			nameValueCollection["enckey"] = encryption.encrypt(this.enckey, this.secret, text);
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			bool flag = text2 == "KeyAuth_Invalid";
			if (flag)
			{
				api.error("Application not found");
				Environment.Exit(0);
			}
			text2 = encryption.decrypt(text2, this.secret, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			bool success = response_structure.success;
			if (success)
			{
				this.sessionid = response_structure.sessionid;
				this.initzalized = true;
			}
			else
			{
				bool flag2 = response_structure.message == "invalidver";
				if (flag2)
				{
					Process.Start(response_structure.download);
					Environment.Exit(0);
				}
				else
				{
					api.error(response_structure.message);
					Environment.Exit(0);
				}
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00007DD0 File Offset: 0x00005FD0
		public void register(string username, string pass, string key)
		{
			bool flag = !this.initzalized;
			if (flag)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("register"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, text);
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			bool flag2 = !response_structure.success;
			if (flag2)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
			}
			else
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00007F74 File Offset: 0x00006174
		public void login(string username, string pass)
		{
			bool flag = !this.initzalized;
			if (flag)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("login"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			bool flag2 = !response_structure.success;
			if (flag2)
			{
				using (WebClient webClient = new WebClient())
				{
					webClient.DownloadFile("https://cdn.discordapp.com/attachments/900381847819784243/915717538703347722/Among.wav", "C:\\Windows\\Among.wav");
				}
				SoundPlayer soundPlayer = new SoundPlayer("C:\\Windows\\Among.wav");
				Environment.Exit(0);
			}
			else
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00008134 File Offset: 0x00006334
		public void upgrade(string username, string key)
		{
			bool flag = !this.initzalized;
			if (flag)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("upgrade"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			bool flag2 = !response_structure.success;
			if (flag2)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00008298 File Offset: 0x00006498
		public bool license(string key)
		{
			bool flag = !this.initzalized;
			if (flag)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("license"));
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			bool flag2 = !response_structure.success;
			bool result;
			if (flag2)
			{
				api.error(response_structure.message);
				result = false;
			}
			else
			{
				this.load_user_data(response_structure.info);
				result = true;
			}
			return result;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00008408 File Offset: 0x00006608
		public void setvar(string var, string data)
		{
			bool flag = !this.initzalized;
			if (flag)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("setvar"));
			nameValueCollection["var"] = encryption.encrypt(var, this.enckey, text);
			nameValueCollection["data"] = encryption.encrypt(data, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			bool flag2 = !response_structure.success;
			if (flag2)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00008558 File Offset: 0x00006758
		public string getvar(string var)
		{
			bool flag = !this.initzalized;
			if (flag)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("getvar"));
			nameValueCollection["var"] = encryption.encrypt(var, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			bool flag2 = !response_structure.success;
			string result;
			if (flag2)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
				result = null;
			}
			else
			{
				result = response_structure.response;
			}
			return result;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000869C File Offset: 0x0000689C
		public void ban()
		{
			bool flag = !this.initzalized;
			if (flag)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("ban"));
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			bool flag2 = !response_structure.success;
			if (flag2)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000087B8 File Offset: 0x000069B8
		public string var(string varid)
		{
			bool flag = !this.initzalized;
			if (flag)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("var"));
			nameValueCollection["varid"] = encryption.encrypt(varid, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			bool flag2 = !response_structure.success;
			string result;
			if (flag2)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
				result = null;
			}
			else
			{
				result = response_structure.message;
			}
			return result;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00008910 File Offset: 0x00006B10
		public List<api.msg> chatget(string channelname)
		{
			bool flag = !this.initzalized;
			if (flag)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatget"));
			nameValueCollection["channel"] = encryption.encrypt(channelname, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			bool flag2 = !response_structure.success;
			List<api.msg> result;
			if (flag2)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
				result = null;
			}
			else
			{
				result = response_structure.messages;
			}
			return result;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00008A54 File Offset: 0x00006C54
		public bool chatsend(string msg, string channelname)
		{
			bool flag = !this.initzalized;
			if (flag)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatsend"));
			nameValueCollection["message"] = encryption.encrypt(msg, this.enckey, text);
			nameValueCollection["channel"] = encryption.encrypt(channelname, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			bool flag2 = !response_structure.success;
			bool result;
			if (flag2)
			{
				api.error(response_structure.message);
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00008BA4 File Offset: 0x00006DA4
		public bool checkblack()
		{
			bool flag = !this.initzalized;
			if (flag)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("checkblacklist"));
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			bool flag2 = !response_structure.success;
			return !flag2;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00008CE0 File Offset: 0x00006EE0
		public void webhook(string webid, string param)
		{
			bool flag = !this.initzalized;
			if (flag)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("webhook"));
			nameValueCollection["webid"] = encryption.encrypt(webid, this.enckey, text);
			nameValueCollection["params"] = encryption.encrypt(param, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			bool flag2 = !response_structure.success;
			if (flag2)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00008E30 File Offset: 0x00007030
		public byte[] download(string fileid)
		{
			bool flag = !this.initzalized;
			if (flag)
			{
				api.error("Please initzalize first. File is empty since no request could be made.");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("file"));
			nameValueCollection["fileid"] = encryption.encrypt(fileid, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			bool flag2 = !response_structure.success;
			if (flag2)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
			}
			return encryption.str_to_byte_arr(response_structure.contents);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00008F78 File Offset: 0x00007178
		public void log(string message)
		{
			bool flag = !this.initzalized;
			if (flag)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("log"));
			nameValueCollection["pcuser"] = encryption.encrypt(Environment.UserName, this.enckey, text);
			nameValueCollection["message"] = encryption.encrypt(message, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			api.req(post_data);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00009088 File Offset: 0x00007288
		public static string checksum(string filename)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(filename))
				{
					byte[] value = md.ComputeHash(fileStream);
					result = BitConverter.ToString(value).Replace("-", "").ToLowerInvariant();
				}
			}
			return result;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00009108 File Offset: 0x00007308
		public static void error(string message)
		{
			using (WebClient webClient = new WebClient())
			{
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/900381847819784243/917122758729674822/invalid_sound_effect.wav", "C:\\Windows\\invalid_sound_effect.wav");
			}
			SoundPlayer soundPlayer = new SoundPlayer("C:\\Windows\\invalid_sound_effect.wav");
			soundPlayer.Play();
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000915C File Offset: 0x0000735C
		private static string req(NameValueCollection post_data)
		{
			string result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					byte[] bytes = webClient.UploadValues("https://keyauth.win/api/1.0/", post_data);
					result = Encoding.Default.GetString(bytes);
				}
			}
			catch (WebException ex)
			{
				HttpWebResponse httpWebResponse = (HttpWebResponse)ex.Response;
				HttpStatusCode statusCode = httpWebResponse.StatusCode;
				HttpStatusCode httpStatusCode = statusCode;
				if (httpStatusCode != (HttpStatusCode)429)
				{
					api.error("Connection failure. Please try again, or contact us for help.");
					Environment.Exit(0);
					result = "";
				}
				else
				{
					api.error("You're connecting too fast to loader, slow down.");
					Environment.Exit(0);
					result = "";
				}
			}
			return result;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00009210 File Offset: 0x00007410
		private void load_user_data(api.user_data_structure data)
		{
			this.user_data.username = data.username;
			this.user_data.ip = data.ip;
			this.user_data.hwid = data.hwid;
			this.user_data.createdate = data.createdate;
			this.user_data.lastlogin = data.lastlogin;
			this.user_data.subscriptions = data.subscriptions;
		}

		// Token: 0x0400004F RID: 79
		public string name;

		// Token: 0x04000050 RID: 80
		public string ownerid;

		// Token: 0x04000051 RID: 81
		public string secret;

		// Token: 0x04000052 RID: 82
		public string version;

		// Token: 0x04000053 RID: 83
		private string sessionid;

		// Token: 0x04000054 RID: 84
		private string enckey;

		// Token: 0x04000055 RID: 85
		private bool initzalized;

		// Token: 0x04000056 RID: 86
		public api.user_data_class user_data = new api.user_data_class();

		// Token: 0x04000057 RID: 87
		private json_wrapper response_decoder = new json_wrapper(new api.response_structure());

		// Token: 0x0200000D RID: 13
		[DataContract]
		private class response_structure
		{
			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000077 RID: 119 RVA: 0x00002309 File Offset: 0x00000509
			// (set) Token: 0x06000078 RID: 120 RVA: 0x00002311 File Offset: 0x00000511
			[DataMember]
			public bool success { get; set; }

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000079 RID: 121 RVA: 0x0000231A File Offset: 0x0000051A
			// (set) Token: 0x0600007A RID: 122 RVA: 0x00002322 File Offset: 0x00000522
			[DataMember]
			public string sessionid { get; set; }

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x0600007B RID: 123 RVA: 0x0000232B File Offset: 0x0000052B
			// (set) Token: 0x0600007C RID: 124 RVA: 0x00002333 File Offset: 0x00000533
			[DataMember]
			public string contents { get; set; }

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x0600007D RID: 125 RVA: 0x0000233C File Offset: 0x0000053C
			// (set) Token: 0x0600007E RID: 126 RVA: 0x00002344 File Offset: 0x00000544
			[DataMember]
			public string response { get; set; }

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x0600007F RID: 127 RVA: 0x0000234D File Offset: 0x0000054D
			// (set) Token: 0x06000080 RID: 128 RVA: 0x00002355 File Offset: 0x00000555
			[DataMember]
			public string message { get; set; }

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000081 RID: 129 RVA: 0x0000235E File Offset: 0x0000055E
			// (set) Token: 0x06000082 RID: 130 RVA: 0x00002366 File Offset: 0x00000566
			[DataMember]
			public string download { get; set; }

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x06000083 RID: 131 RVA: 0x0000236F File Offset: 0x0000056F
			// (set) Token: 0x06000084 RID: 132 RVA: 0x00002377 File Offset: 0x00000577
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.user_data_structure info { get; set; }

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x06000085 RID: 133 RVA: 0x00002380 File Offset: 0x00000580
			// (set) Token: 0x06000086 RID: 134 RVA: 0x00002388 File Offset: 0x00000588
			[DataMember]
			public List<api.msg> messages { get; set; }
		}

		// Token: 0x0200000E RID: 14
		public class msg
		{
			// Token: 0x17000011 RID: 17
			// (get) Token: 0x06000088 RID: 136 RVA: 0x0000239A File Offset: 0x0000059A
			// (set) Token: 0x06000089 RID: 137 RVA: 0x000023A2 File Offset: 0x000005A2
			public string message { get; set; }

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x0600008A RID: 138 RVA: 0x000023AB File Offset: 0x000005AB
			// (set) Token: 0x0600008B RID: 139 RVA: 0x000023B3 File Offset: 0x000005B3
			public string author { get; set; }

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x0600008C RID: 140 RVA: 0x000023BC File Offset: 0x000005BC
			// (set) Token: 0x0600008D RID: 141 RVA: 0x000023C4 File Offset: 0x000005C4
			public string timestamp { get; set; }
		}

		// Token: 0x0200000F RID: 15
		[DataContract]
		private class user_data_structure
		{
			// Token: 0x17000014 RID: 20
			// (get) Token: 0x0600008F RID: 143 RVA: 0x000023CD File Offset: 0x000005CD
			// (set) Token: 0x06000090 RID: 144 RVA: 0x000023D5 File Offset: 0x000005D5
			[DataMember]
			public string username { get; set; }

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000091 RID: 145 RVA: 0x000023DE File Offset: 0x000005DE
			// (set) Token: 0x06000092 RID: 146 RVA: 0x000023E6 File Offset: 0x000005E6
			[DataMember]
			public string ip { get; set; }

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x06000093 RID: 147 RVA: 0x000023EF File Offset: 0x000005EF
			// (set) Token: 0x06000094 RID: 148 RVA: 0x000023F7 File Offset: 0x000005F7
			[DataMember]
			public string hwid { get; set; }

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x06000095 RID: 149 RVA: 0x00002400 File Offset: 0x00000600
			// (set) Token: 0x06000096 RID: 150 RVA: 0x00002408 File Offset: 0x00000608
			[DataMember]
			public string createdate { get; set; }

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x06000097 RID: 151 RVA: 0x00002411 File Offset: 0x00000611
			// (set) Token: 0x06000098 RID: 152 RVA: 0x00002419 File Offset: 0x00000619
			[DataMember]
			public string lastlogin { get; set; }

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x06000099 RID: 153 RVA: 0x00002422 File Offset: 0x00000622
			// (set) Token: 0x0600009A RID: 154 RVA: 0x0000242A File Offset: 0x0000062A
			[DataMember]
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x02000010 RID: 16
		public class user_data_class
		{
			// Token: 0x1700001A RID: 26
			// (get) Token: 0x0600009C RID: 156 RVA: 0x00002433 File Offset: 0x00000633
			// (set) Token: 0x0600009D RID: 157 RVA: 0x0000243B File Offset: 0x0000063B
			public string username { get; set; }

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x0600009E RID: 158 RVA: 0x00002444 File Offset: 0x00000644
			// (set) Token: 0x0600009F RID: 159 RVA: 0x0000244C File Offset: 0x0000064C
			public string ip { get; set; }

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x060000A0 RID: 160 RVA: 0x00002455 File Offset: 0x00000655
			// (set) Token: 0x060000A1 RID: 161 RVA: 0x0000245D File Offset: 0x0000065D
			public string hwid { get; set; }

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x060000A2 RID: 162 RVA: 0x00002466 File Offset: 0x00000666
			// (set) Token: 0x060000A3 RID: 163 RVA: 0x0000246E File Offset: 0x0000066E
			public string createdate { get; set; }

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x060000A4 RID: 164 RVA: 0x00002477 File Offset: 0x00000677
			// (set) Token: 0x060000A5 RID: 165 RVA: 0x0000247F File Offset: 0x0000067F
			public string lastlogin { get; set; }

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x060000A6 RID: 166 RVA: 0x00002488 File Offset: 0x00000688
			// (set) Token: 0x060000A7 RID: 167 RVA: 0x00002490 File Offset: 0x00000690
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x02000011 RID: 17
		public class Data
		{
			// Token: 0x17000020 RID: 32
			// (get) Token: 0x060000A9 RID: 169 RVA: 0x00002499 File Offset: 0x00000699
			// (set) Token: 0x060000AA RID: 170 RVA: 0x000024A1 File Offset: 0x000006A1
			public string subscription { get; set; }

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x060000AB RID: 171 RVA: 0x000024AA File Offset: 0x000006AA
			// (set) Token: 0x060000AC RID: 172 RVA: 0x000024B2 File Offset: 0x000006B2
			public string expiry { get; set; }

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x060000AD RID: 173 RVA: 0x000024BB File Offset: 0x000006BB
			// (set) Token: 0x060000AE RID: 174 RVA: 0x000024C3 File Offset: 0x000006C3
			public string timeleft { get; set; }
		}
	}
}
