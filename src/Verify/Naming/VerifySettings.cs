namespace Verify
{
    public partial class VerifySettings
    {
        internal Namer Namer = new Namer();

        public VerifySettings UniqueForAssemblyConfiguration()
        {
            Namer.UniqueForAssemblyConfiguration = true;
            return this;
        }

        public VerifySettings UniqueForRuntime()
        {
            Namer.UniqueForRuntime = true;
            return this;
        }

        public VerifySettings UniqueForRuntimeAndVersion()
        {
            Namer.UniqueForRuntimeAndVersion = true;
            return this;
        }
    }
}