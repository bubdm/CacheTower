using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CacheTower.Tests
{
	[TestClass]
	public class MemoryCacheLayerTests : BaseCacheLayerTests
	{
		[TestMethod]
		public async Task GetSetCache()
		{
			await AssertGetSetCache(new MemoryCacheLayer());
		}

		[TestMethod]
		public async Task IsCacheAvailable()
		{
			await AssertCacheAvailability(new MemoryCacheLayer(), true);
		}

		[TestMethod]
		public async Task EvictFromCache()
		{
			await AssertCacheEviction(new MemoryCacheLayer());
		}

		[TestMethod]
		public async Task CacheCleanup()
		{
			await AssertCacheCleanup(new MemoryCacheLayer());
		}
	}
}
