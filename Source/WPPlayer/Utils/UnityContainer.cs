using System;
using System.Collections.Generic;
using System.Linq;

namespace WPPlayer.Utils
{
    public class UnityContainer : IUnityContainer
    {
        private static UnityContainer _containerInstance;

        readonly IDictionary<Type, KeyValuePair<Type, object>> _instances = new Dictionary<Type, KeyValuePair<Type, object>>();

        public static UnityContainer Instance
        {
            get { return _containerInstance ?? (_containerInstance = new UnityContainer()); }
        }

        public void Register<TInterface, TImplementation>()
        {
            _instances.Add(typeof (TInterface), new KeyValuePair<Type, object>(typeof(TImplementation), null));
        }

        public T Resolve<T>() where T : class
        {
            lock(this)
            {
                var interfaceType = typeof (T);
                return Resolve(interfaceType) as T;
            }
        }

        private object Resolve(Type interfaceType)
        {
            var implementingType = _instances[interfaceType].Key;

            if (_instances[interfaceType].Value == null)
            {
                var constructors = implementingType.GetConstructors();

                var parameters = new List<object>();

                var parameterizedConstructor = constructors.FirstOrDefault(constructor => constructor.GetParameters().Length > 0);

                object implementingObject;

                if (parameterizedConstructor != null)
                {
                    parameters.AddRange(parameterizedConstructor.GetParameters().Select(parameter => Resolve(parameter.ParameterType)));
                    implementingObject = Activator.CreateInstance(implementingType, parameters.ToArray());
                }
                else
                {
                    implementingObject = Activator.CreateInstance(implementingType);                    
                }

                _instances[interfaceType] = new KeyValuePair<Type, object>(implementingType, implementingObject);
            }

            return _instances[interfaceType].Value;

        }
    }
}
