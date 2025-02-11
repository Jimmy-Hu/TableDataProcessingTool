using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TableDataProcessingTool.CSharpFiles.Protobuf
{
    [ProtoContract]
    public class BaseClass
    {
        public static T DeepClone<T>(T obj)
        {
            if (obj == null)
            {
                return default(T); // Handle null input
            }
            using (var ms = new MemoryStream())
            {
                Serializer.Serialize(ms, obj);
                ms.Position = 0;
                return Serializer.Deserialize<T>(ms);
            }
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
