﻿namespace NServiceBus.AmazonSQS.IntegrationTests
{
	using NUnit.Framework;
	
	[TestFixture]
	public class when_creating_queues
	{
		SqsTestContext _context;

        [TestFixtureSetUp]
        public void SetUp()
        {
			_context = new SqsTestContext(this);
        }

		[TestFixtureTearDown]
		public void TearDown()
		{
			_context.Dispose();
		}

		[Test]
		public void creating_queue_works()
		{
			Assert.DoesNotThrow(() => _context.CreateQueue());

			Assert.IsTrue( _context.MyQueueExists() );
		}
	}
}
