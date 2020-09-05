using System;
using System.Reflection;

namespace FacadeLayer
{
	public static class Singleton<T>
		where T : class
	{
		static volatile T s_Instance;
		static object s_lock = new object();

		static Singleton()
		{
		}


		public static T Instance
		{
			get
			{
				if (s_Instance == null)
					lock (s_lock)
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

							if (constructor == null || constructor.IsAssembly) // Also exclude internal constructors.
								throw new SingletonException(string.Format("A private or protected constructor is missing for '{0}'.", typeof(T).Name));

							s_Instance = (T)constructor.Invoke(null);
						}
					}

				return s_Instance;
			}
		}
	}
}
