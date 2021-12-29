using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace KeyAuth
{
	// Token: 0x02000013 RID: 19
	public class json_wrapper
	{
		// Token: 0x060000B8 RID: 184 RVA: 0x000024E8 File Offset: 0x000006E8
		public static bool is_serializable(Type to_check)
		{
			return to_check.IsSerializable || to_check.IsDefined(typeof(DataContractAttribute), true);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000095BC File Offset: 0x000077BC
		public json_wrapper(object obj_to_work_with)
		{
			this.current_object = obj_to_work_with;
			Type type = this.current_object.GetType();
			this.serializer = new DataContractJsonSerializer(type);
			bool flag = !json_wrapper.is_serializable(type);
			if (flag)
			{
				throw new Exception(string.Format("the object {0} isn't a serializable", this.current_object));
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00009614 File Offset: 0x00007814
		public object string_to_object(string json)
		{
			byte[] bytes = Encoding.Default.GetBytes(json);
			object result;
			using (MemoryStream memoryStream = new MemoryStream(bytes))
			{
				result = (memoryStream);
			}
			return result;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002506 File Offset: 0x00000706
		public T string_to_generic<T>(string json)
		{
			return (T)((object)this.string_to_object(json));
		}

		// Token: 0x04000072 RID: 114
		private DataContractJsonSerializer serializer;

		// Token: 0x04000073 RID: 115
		private object current_object;
	}
}
