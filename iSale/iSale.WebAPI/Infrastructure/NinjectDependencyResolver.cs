using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Moq;
using Ninject;
using iSale.Domain.Abstract;
using iSale.Domain.Concrete;
using iSale.Domain.Entities;

namespace iSale.WebUI.Infrastructure
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
             //Mock<IEventRepository> mock = new Mock<IEventRepository>();
             //mock.Setup(m => m.Users).Returns(new List<User>
             //{
             //    new User { NickName = "A", Email = "a@a.a", PhoneNumber = "987 654 3210", Rating = 5, RegistrationDate = DateTime.UtcNow.AddDays(-3) },
             //    new User { NickName = "B", Email = "b@b.b", PhoneNumber = "456 123 0789", Rating = 4, RegistrationDate = DateTime.UtcNow.AddDays(-2) },
             //    new User { NickName = "C", Email = "c@c.c", PhoneNumber = "123 045 6789", Rating = 3, RegistrationDate = DateTime.UtcNow.AddDays(-1) }
             //});
             //
             //kernel.Bind<IEventRepository>().ToConstant(mock.Object);

            kernel.Bind<IEventRepository>().To<EFSaleRepository>();
        }
    }
}