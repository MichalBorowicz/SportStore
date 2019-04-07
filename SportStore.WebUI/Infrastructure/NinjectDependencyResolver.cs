using Moq;
using Ninject;
using SportStore.Domain.Abstract;
using SportStore.Domain.Concrete;
using SportStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportStore.WebUI.Infrastructure
{
	public class NinjectDependencyResolver : IDependencyResolver
	{
		private IKernel kernel;
		public NinjectDependencyResolver(IKernel kernelParam)
		{
			kernel = kernelParam;
			AddBindings();
		}

		public object GetService(Type serviceType)
		{
			return kernel.TryGet(serviceType);
		}

		public IEnumerable<object> GetServices(Type serviceType)
		{
			return kernel.GetAll(serviceType);
		}

		private void AddBindings()
		{
			kernel.Bind<IProductRepository>().To<ProductRepository>();
			//Mock<IProductRepository> mock = new Mock<IProductRepository>();
			//mock.Setup(m => m.Products).Returns(
			//	new List<Product>
			//	{
			//		new Product{ Name ="Keyboard", Description =" Very nice keybord", Price = "10.2"},
			//		new Product{Name ="Mouse", Description = "Small", Price = "122.3"}
			//	});
			//kernel.Bind<IProductRepository>().ToConstant(mock.Object);
		}
	}
}