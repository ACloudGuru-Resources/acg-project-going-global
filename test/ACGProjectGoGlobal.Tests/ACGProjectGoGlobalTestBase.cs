using System;
using System.Threading.Tasks;
using Abp.TestBase;
using ACGProjectGoGlobal.EntityFrameworkCore;
using ACGProjectGoGlobal.Tests.TestDatas;

namespace ACGProjectGoGlobal.Tests
{
    public class ACGProjectGoGlobalTestBase : AbpIntegratedTestBase<ACGProjectGoGlobalTestModule>
    {
        public ACGProjectGoGlobalTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<ACGProjectGoGlobalDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<ACGProjectGoGlobalDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<ACGProjectGoGlobalDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<ACGProjectGoGlobalDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<ACGProjectGoGlobalDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<ACGProjectGoGlobalDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<ACGProjectGoGlobalDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<ACGProjectGoGlobalDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
