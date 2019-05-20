using Anug.Pipeline.NugetPackage;
using Xunit;

namespace Test
{
    public class Demo_should
    {
        [Fact]
        public void Return_what_we_expect()
        {
            var sut = new Demo();

            var actual = sut.Hallo();

            Assert.Equal("Hi ANUG!", actual);
        }

        [Fact]
        public void Also_return_what_we_expect_the_second_time()
        {
            var sut = new Demo();

            sut.Hallo();
            var actual = sut.Hallo();
            Assert.Equal("Hi ANUG!", actual);
        }
    }
}
