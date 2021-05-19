using System;
using System.Collections.Generic;
using System.Linq;

namespace DI_Container
{
    public static class DIContainer
    {
        private static readonly Dictionary<Type, Type> _container = new();

        public static void Register<T1, T2>()
        {
            _container.Add(typeof(T1), typeof(T2));
        }

        public static T GetInstance<T>()
        {
            var constructor = _container[typeof(T)].GetConstructors().First();
            var parameters = constructor.GetParameters().ToList();

            if (!parameters.Any())
            {
                return (T) constructor.Invoke(Array.Empty<object>());
            }

            var parameterInstances = new List<object>();
            foreach (var parameter in parameters)
            {
                parameterInstances.Add(typeof(DIContainer)
                    .GetMethod("GetInstance")?
                    .MakeGenericMethod(parameter.ParameterType)
                    .Invoke(null, Array.Empty<object>()));
            }

            return (T) constructor.Invoke(parameterInstances.ToArray());
        }
    }
}