using System;
using Microsoft.QualityTools.Testing.Fakes;

namespace ManheimEventApiTest
{
    public abstract class TestBase<T> : IDisposable where T : class
    {
        private IDisposable _shimsContext;

        protected T ClassUnderTest { get; set; }

        protected TestBase()
        {
            _shimsContext = ShimsContext.Create();
        }

        public void InstantiateClassUnderTest(params object[] parameters)
        {
            ClassUnderTest = (T)Activator.CreateInstance(typeof(T), parameters);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                _shimsContext.Dispose();
                _shimsContext = null;
            }
        }
    }
}
