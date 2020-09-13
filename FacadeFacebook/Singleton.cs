using System;
using System.Reflection;

namespace FacadeLayer
{
	public static class Singleton<T>
		where T : class
	{
		public static volatile T s_Instance;

		public static object s_Lock = new object();

		static Singleton()
		{
		}

		public static T Instance
		{
			get
			{
                if (s_Instance == null)
                {
                    lock (s_Lock)
                    {
                        if (s_Instance == null)
                        {
                            ConstructorInfo constructor = null;

                            try
                            {
                                constructor = typeof(T).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[0], null);
                            }
                            catch (Exception exception)
                            {
                                throw new SingletonException(exception);
                            }

                            if (constructor == null || constructor.IsAssembly)
                            {
                                throw new SingletonException(string.Format("A private or protected constructor is missing for '{0}'.", typeof(T).Name));
                            }

                            s_Instance = (T)constructor.Invoke(null);
                        }
                    }
                }

				return s_Instance;
			}
		}
	}
}
