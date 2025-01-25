using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TableDataProcessingTool.CSharpFiles
{
	[Serializable()]
	public class BaseClass
	{
		//	Reference: https://stackoverflow.com/a/222761/6667035
		public static object DeepClone(object obj)
		{
			object objResult = null;

			using (var ms = new System.IO.MemoryStream())
			{
				var bf = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
				bf.Serialize(ms, obj);

				ms.Position = 0;
				objResult = bf.Deserialize(ms);
			}
			return objResult;
		}

		//	Reference: https://stackoverflow.com/a/49160189/6667035
		public object ExecuteWithReflection(string methodName, object classInstanceInput = null, object parameterObject = null)
		{
			Type typeInstance = this.GetType();

			if (typeInstance != null)
			{
				System.Reflection.MethodInfo methodInfo = typeInstance.GetMethod(methodName);
				ParameterInfo[] parameterInfo = methodInfo.GetParameters();

				if (classInstanceInput is null)
				{
					object classInstance = Activator.CreateInstance(typeInstance, null);

					if (parameterInfo.Length == 0)
					{
						// there is no parameter we can call with 'null'
						return methodInfo.Invoke(classInstance, null);
					}
					else
					{
						return methodInfo.Invoke(classInstance, new object[] { parameterObject });
					}
				}
				else
				{
					if (parameterInfo.Length == 0)
					{
						// there is no parameter we can call with 'null'
						return methodInfo.Invoke(classInstanceInput, null);
					}
					else
					{
						return methodInfo.Invoke(classInstanceInput, new object[] { parameterObject });
					}
				}
				
			}
			return null;
		}
	}
}
