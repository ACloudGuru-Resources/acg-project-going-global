using ACGProjectGoGlobal.EntityFrameworkCore;

namespace ACGProjectGoGlobal.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly ACGProjectGoGlobalDbContext _context;

        public TestDataBuilder(ACGProjectGoGlobalDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}