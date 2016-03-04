using System;
using MetaWpf.Infrastructures.Abstracts;
using Microsoft.Practices.Unity;

namespace MetaWpf.Infrastructures
{
    public class MetaWpfBoot
    {
        private readonly IUnityContainer _container;

        public MetaWpfBoot(IUnityContainer container)
		{
			this._container = container;
		}

        public MetaWpfBoot RegisterModule(Type moduleType)
		{
			var module = this._container.Resolve(moduleType) as IModule;
			if (module == null)
				throw new ArgumentException("moduleType");
			module.Register(this._container);
			return this;
		}
    }
}
