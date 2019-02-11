using System;
using System.Collections.Generic;
using WidgetFramework.Contracts.Configuration;
using WidgetFramework.Contracts.Container;

namespace WidgetFramework.Implementation.Configuration
{
    public class Configuration : IConfiguration
    {
        private List<Type> m_dependencies = new List<Type>();
        
        public WidgetUsage Usage { get; set; }
        public void AddDependency<T>()
        {
            m_dependencies.Add(typeof(T));
        }
    }
}