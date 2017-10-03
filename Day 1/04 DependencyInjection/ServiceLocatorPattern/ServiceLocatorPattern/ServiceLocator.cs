using System;
using System.Collections.Generic;

namespace ServiceLocatorPattern
{
    internal class ServiceLocator : IServiceLocator
    {
        // Maps contracts to concrete implementation classes
        private IDictionary<Type, Type> servicesType;

        // Maps contracts to implementation classes already implemented
        private IDictionary<Type, object> instantiatedServices;

        internal ServiceLocator()
        {
            // build dictionary of available types
            servicesType = new Dictionary<Type, Type>();

            // build dictionariy of instantiated types
            instantiatedServices = new Dictionary<Type, object>();
            BuildServicesTypeMap();
        }

        public T GetService<T>()
        {
            // return instance of object if already instantiates
            if (instantiatedServices.ContainsKey(typeof (T)))
            {
                return (T) instantiatedServices[typeof (T)];
            }

            // lazy initialization - instantiate object just as needed
            try
            {
                // use reflection to invoke the service.
                // user reflection to find object in dictionary
                var constructor = servicesType[typeof (T)].GetConstructor(new Type[0]);

                if (constructor == null)
                    throw new KeyNotFoundException("The requested service is not registered");

                // create the object via reflection
                var service = (T) constructor.Invoke(null);

                // add the service to the dictionary of instantiated servoices
                instantiatedServices.Add(typeof (T), service);

                return service;
            }
            catch (KeyNotFoundException ex)
            {
                throw new ApplicationException("The requested service is not registered");
            }
        }

        /// <summary>
        /// Build dictionary of available services
        /// </summary>
        private void BuildServicesTypeMap()
        {
            // maps dependency objects to the dictionary of available services
            servicesType.Add(typeof (IServiceA), typeof (ServiceA));
            servicesType.Add(typeof (IServiceB), typeof (ServiceB));
            servicesType.Add(typeof (IServiceC), typeof (ServiceC));
        }
    }
}